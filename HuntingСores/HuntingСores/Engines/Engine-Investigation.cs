using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HuntingСores
{
    public class Engine_Investigation : Engine_Basic
    {
        private Person _monster;
        private List<Person> _listAllPerson;
        private Person _chars_search;

        private Random rand = new Random();

        private Dictionary<TypeCharacteristic, List<string>> Texts;

        public Engine_Investigation(int _numPeopleStart, Person _personSearch, Person _charKnown, Dictionary<TypeCharacteristic, List<string>> _texts)
        {
            _monster = _personSearch;
            _chars_search = _charKnown;
            _listAllPerson = new List<Person>();
            Texts = _texts;

            for (int i = 0; i < _numPeopleStart; i++)
            {
                var p = new Person();
                while(true)
                {
                    p = new Person
                    {
                        Name = $"{i}",
                        Characteristics = Characteristic.AllCharacteristics.Select((typeCharacter, pos) => typeCharacter.Value[rand.Next(typeCharacter.Value.Count)]).ToList()
                    };

                    if ((_monster.Characteristics.Select(x => p.Characteristics.Where(y => x.Name == y.Name).Count()).Sum() != _monster.Characteristics.Count))
                        break;
                }
                _listAllPerson.Add(p);
            }

            _listAllPerson.Insert(rand.Next(_listAllPerson.Count), _personSearch);
        }

        public Tuple<string, List<Characteristic>> NextEvent(int chance_determining)
        {
            List<Characteristic> post = _monster.Characteristics.Where(x => _chars_search.Characteristics.Where(y => x.Name == y.Name).Count() == 0).ToList();
            post = new List<Characteristic> { post[rand.Next(post.Count)] };

            var list_char = new List<Person>();

            
            var text = Texts[post[0].Type][rand.Next(Texts[post[0].Type].Count)];
            if (text is null)
            {
                text = $"Нет больше текста для типа {post[0].Type}! Пользователи требуют больше текста.";
            }
            else
            {
                Texts[post[0].Type].Remove(text);
            }


            var pos = (rand.Next(100) >= (100 * ((chance_determining/100.0) * (chance_determining/100.0))) ? 1 : 0);
            
            if(pos > 0)
            {

                var p = 0;
                foreach(var e in Characteristic.AllCharacteristics[post[0].Type])
                {
                    if (e.Name == post[0].Name)
                        break;
                    p++;
                }

                if (p == 0)
                {
                    post.Add(Characteristic.AllCharacteristics[post[0].Type][1]);
                }
                else if (p == Characteristic.AllCharacteristics[post[0].Type].Count - 1)
                {
                    post.Add(Characteristic.AllCharacteristics[post[0].Type][Characteristic.AllCharacteristics[post[0].Type].Count - 2]);
                }
                else
                {
                    post.Add(Characteristic.AllCharacteristics[post[0].Type][(new List<int> { (int)p - 1, (int)p + 1 })[(int)Math.Round(rand.NextDouble(), 0)]]);
                }
            }

            return Tuple.Create(text, post);
        }

        public void Answer(Characteristic _characteristic)
        {
            var charact = _chars_search.Characteristics.Where(x => x.Type == _characteristic.Type);

            if (charact.Count() != 0)
            {
                charact.First().Name = _characteristic.Name;
            }
            else
            {
                _chars_search.Characteristics.Add(_characteristic);
            }
        }

        public List<Person> GetSurmise()
        {
            var list = new List<Person>();
            var listNameChar = _chars_search.Characteristics.Select(x => x.Name);
            var type = _chars_search.Characteristics.ToDictionary(x => x.Type, x => x.Name);
            var hash = _chars_search.Characteristics.Select(x => x.Type).ToHashSet();
            foreach (var p in _listAllPerson)
            {
                if (p.Characteristics.Where(x => hash.Contains(x.Type) && type[x.Type] != x.Name).Count() == 0)
                    list.Add(p);
            }
            return list;
        }

        public bool IsMonsterFind()
        {
            return GetSurmise().Count == 1 
                && _chars_search.Characteristics
                    .Where(x => x.Name != NameCharacteristic.Unknown)
                    .Select(x => _monster.Characteristics
                    .Where(y => y.Name == x.Name).Count() > 0)
                    .Where(x => !x).Count() == 0;
        }
    }
}
