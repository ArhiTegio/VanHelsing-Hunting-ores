using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace HuntingСores
{
    public class Engine_HuntingToMonster : Engine_Basic
    {
        private double _initDistance = 0;
        private double _distanceHabitat = 0;
        private Person _monster;
        private Person _monster_search = new Person();
        Dictionary<TypeCharacteristic, Dictionary<Danger, List<string>>> _textsEvents;
        Dictionary<TypeCharacteristic, Dictionary<Danger, List<string>>> _textsNotFindDanger;
        Dictionary<Danger, List<string>> _textsFindDanger;
        public Danger ChanceDanger = Danger.VeryLow;
        private TypeCharacteristic _typeCharacteristic; 


        private Random rand = new Random();


        public Engine_HuntingToMonster(Person _monster, double _distanceHabitat,
            Dictionary<TypeCharacteristic, Dictionary<Danger, List<string>>> _textsEvents,
            Dictionary<TypeCharacteristic, Dictionary<Danger, List<string>>> _textsNotFindDanger,
            Dictionary<Danger, List<string>> _textsFindDanger)
        {
            this._monster = _monster;
            this._initDistance = _distanceHabitat;
            this._distanceHabitat = _distanceHabitat;
            this._textsEvents = _textsEvents;
            this._textsNotFindDanger = _textsNotFindDanger;
            this._textsFindDanger = _textsFindDanger;
        }


        public Person KnownCharacteristics() => _monster_search;


        public Person GetMonster() => _monster;


        public string NextEvent(int chance)
        {
            

            var c = 0;
            for (int i = 0; i < 5; ++i)
            {
                c += rand.Next(70) <= chance ? 1 : 0;
                c -= rand.Next(100) <= chance ? 1 : 0;
            }


            if(c >= 1 && (int)ChanceDanger != 0)
            {
                c = 1;
            }
            else if (c <= -1 && (int)ChanceDanger != Enum.GetValues(typeof(Danger)).Length - 1)
            {
                c = -1;
            }
            else if((int)ChanceDanger == Enum.GetValues(typeof(Danger)).Length - 1)
            {
                c = 0;
            }
            else
            {
                c = 0;
            }

            ChanceDanger = (Danger)((int)ChanceDanger - c);
            if (ChanceDanger < 0)
                ChanceDanger = Danger.VeryLow;

            var charct = _monster.Characteristics.Select(x => x.Name);
            var charactKnow = _monster_search.Characteristics.Where(y => charct.Contains(y.Name)).Select(x => x.Type).ToArray();
            var charactUnknow = _monster.Characteristics.Select(x => x.Type).Where(y => !charactKnow.Contains(y)).ToArray();

            _typeCharacteristic = charactUnknow[rand.Next(0, charactUnknow.Length - 1)];

            var _answer = _textsEvents[_typeCharacteristic][ChanceDanger][rand.Next(0, _textsEvents[_typeCharacteristic][ChanceDanger].Count - 1)];
            _textsEvents[_typeCharacteristic][ChanceDanger].Remove(_answer);

            return _answer;
        }

        public bool IsMonsterHabitatFind() => ChanceDanger == Danger.KnowHabitat;

        public IsFindDanger TryFindMonster(int chance, int skillPathfinder)
        {
            var c = rand.Next(chance);
            _distanceHabitat -= (((c / 100.0)) * _initDistance) / 2;
            if (_distanceHabitat < 0.001)
                ChanceDanger = Danger.KnowHabitat;

            if (_distanceHabitat < 0)
                _distanceHabitat = 0.000001;

            var t1 = (Enum.GetValues(typeof(Danger)).Length - (int)ChanceDanger) / 10.0;
            var t2 = (1 - (_distanceHabitat / _initDistance));

            var isMonster = (int)ChanceDanger == 0 ? true 
                : rand.Next(100) <= ((t1 + t2)/ 2.5) * 100? true 
                : false;

            var charactMonster = _monster.Characteristics.Where(x => x.Type == _typeCharacteristic).ToArray();

            List<NameCharacteristic> listCharact = new List<NameCharacteristic>();

            if (charactMonster.Length != 0)
            {
                listCharact.Add(charactMonster[0].Name);
                if (charactMonster[0].Name == 0)
                {
                    listCharact.Add((NameCharacteristic)((int)charactMonster[0].Name + 1));
                }
                else if ((int)charactMonster[0].Name == Enum.GetValues(typeof(NameCharacteristic)).Length - 1)
                {
                    listCharact.Add((NameCharacteristic)((int)charactMonster[0].Name - 1));
                }
                else
                {
                    listCharact.Add((NameCharacteristic)((int)charactMonster[0].Name + 1));
                    listCharact.Add((NameCharacteristic)((int)charactMonster[0].Name - 1));
                }
            }

            c = rand.Next(skillPathfinder);
            var charact = 100 * ((c / 100.0)) <= 30 ? new Characteristic(_typeCharacteristic, NameCharacteristic.Unknown)
                : new Characteristic(_typeCharacteristic, charactMonster.Length == 0 ? NameCharacteristic.Unknown 
                    : 100 * (c / 100.0) >= 20 
                        ? charactMonster.First().Name 
                        : listCharact[rand.Next(0, listCharact.Count - 1)]);

            if(_monster_search.Characteristics.Select(x => x.Type).Count() > 0)
            {
                var list = _monster_search.Characteristics.Where(x=> x.Type == charact.Type);

                foreach(var e in list)
                {
                    e.Name = charact.Name;
                }
            }
            else
            {
                _monster_search.Characteristics.Add(charact);
            }

            if (isMonster)
            {
                var txt = _textsFindDanger[ChanceDanger][rand.Next(0, _textsFindDanger[ChanceDanger].Count - 1)];
                if (_textsFindDanger[ChanceDanger].Count > 1)
                    _textsFindDanger[ChanceDanger].Remove(txt);
                return new IsFindDanger { FindMonster = true, Text = txt, NewKnowCharact = charact };
            }
            else
            {
                var txt = _textsNotFindDanger[_typeCharacteristic][ChanceDanger][rand.Next(0, _textsFindDanger[ChanceDanger].Count - 1)];
                if (_textsNotFindDanger[_typeCharacteristic][ChanceDanger].Count > 1)
                    _textsNotFindDanger[_typeCharacteristic][ChanceDanger].Remove(txt);
                return new IsFindDanger { FindMonster = false, Text = txt, NewKnowCharact = charact };
            }
        }

        public Danger GetLevelDanger(int chance)
        {
            
            var isAccurateAssessment = rand.Next(100) >= (100 * ((chance / 100.0) * (chance / 100.0)));

            if(isAccurateAssessment)
            {
                return ChanceDanger;
            }
            else
            {
                if (Enum.GetValues(typeof(Danger)).Length - 2 == (int)ChanceDanger)
                {
                    var danger = (Danger)(Enum.GetValues(typeof(Danger)).Length - 1 - (int)Math.Round(rand.Next() * 2.0, 0));
                    if (danger < 0) danger = Danger.Average;
                    return danger;
                }
                else if ((int)ChanceDanger == 0)
                {
                    var danger = (Danger)((int)Math.Round(rand.Next() * 2.0, 0));
                    if (danger < 0) danger = Danger.Average;
                    return danger;
                }
                else
                {
                    var danger = (Danger)((int)ChanceDanger + (new int[] { -1, 1 })[(int)Math.Round(rand.NextDouble(), 0)]);
                    if (danger < 0) danger = Danger.Average;
                    return danger;
                }
            }
        }
    }

    public class IsFindDanger
    {
        public string Text;
        public Characteristic NewKnowCharact;
        public bool FindMonster;
    }

    public enum Danger
    {
        KnowHabitat,
        VeryHigh,
        High,
        Average,
        Low,
        VeryLow
    }
}
