using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace HuntingСores
{
    public class Engine_Reverse
    {
        private Dictionary<Specialization, List<Localization>> _locationForPerson = new Dictionary<Specialization, List<Localization>>
        {
            {
                Specialization.Hunter,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.Forest, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                    new Localization { LocationVisit = LocationVisit.Swamp, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                    new Localization { LocationVisit = LocationVisit.MountainForest, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Poor, TypeVisits = new List<TypeVisit> { TypeVisit.Home }, },
                    new Localization { LocationVisit = LocationVisit.Village, TypeVisits = new List<TypeVisit> { TypeVisit.Home }, },
                }
            },
            {
                Specialization.Mason,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.Mountains, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                    new Localization { LocationVisit = LocationVisit.MountainForest, TypeVisits = new List<TypeVisit> { TypeVisit.Road }, },
                    new Localization { LocationVisit = LocationVisit.CityIndustrialZone, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Poor, TypeVisits = new List<TypeVisit> { TypeVisit.Home }, },
                }
            },
            {
                Specialization.Woodcutter,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.Forest, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                    new Localization { LocationVisit = LocationVisit.MountainForest, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                    new Localization { LocationVisit = LocationVisit.Village, TypeVisits = new List<TypeVisit> { TypeVisit.Home }, },
                }
            },
            {
                Specialization.TavernKeeper,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Poor, TypeVisits = new List<TypeVisit> { TypeVisit.Work, TypeVisit.Home }, },
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Rich, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                }
            },
            {
                Specialization.Courtesan,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Poor, TypeVisits = new List<TypeVisit> { TypeVisit.Work, TypeVisit.Home }, },
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Rich, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                }
            },
            {
                Specialization.Warder,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.MunicipalSewerage, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                    new Localization { LocationVisit = LocationVisit.CityIndustrialZone, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Poor, TypeVisits = new List<TypeVisit> { TypeVisit.Work, TypeVisit.Home }, },
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Rich, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                    new Localization { LocationVisit = LocationVisit.CityOutpost_WithPrison, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                    new Localization { LocationVisit = LocationVisit.VegetableGardens_OutsideCity, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                    new Localization { LocationVisit = LocationVisit.CitizensFields_OutsideTheCity, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                }
            },
            {
                Specialization.Marshal,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Rich, TypeVisits = new List<TypeVisit> { TypeVisit.Home }, },
                    new Localization { LocationVisit = LocationVisit.CityOutpost_WithPrison, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                }
            },
            {
                Specialization.Judge,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Rich, TypeVisits = new List<TypeVisit> { TypeVisit.Home }, },
                }
            },
            {
                Specialization.ChiefGuard,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Rich, TypeVisits = new List<TypeVisit> { TypeVisit.Home }, },
                    new Localization { LocationVisit = LocationVisit.CityOutpost_WithPrison, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                }
            },
            {
                Specialization.OfficerGuard,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.MunicipalSewerage, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                    new Localization { LocationVisit = LocationVisit.CityIndustrialZone, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Poor, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Rich, TypeVisits = new List<TypeVisit> { TypeVisit.Work, TypeVisit.Home }, },
                    new Localization { LocationVisit = LocationVisit.CityOutpost_WithPrison, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                    new Localization { LocationVisit = LocationVisit.VegetableGardens_OutsideCity, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                    new Localization { LocationVisit = LocationVisit.CitizensFields_OutsideTheCity, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                }
            },
            {
                Specialization.Jailer,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Poor, TypeVisits = new List<TypeVisit> { TypeVisit.Home }, },
                    new Localization { LocationVisit = LocationVisit.CityOutpost_WithPrison, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                }
            },
            {
                Specialization.LocalGovernor,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.UrbanResidentialArea_Rich, TypeVisits = new List<TypeVisit> { TypeVisit.Home }, },
                }
            },
            {
                Specialization.Bard,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.Forest, TypeVisits = new List<TypeVisit> { TypeVisit.Road }, },
                    new Localization { LocationVisit = LocationVisit.Plain, TypeVisits = new List<TypeVisit> { TypeVisit.Road }, },
                }
            },
            {
                Specialization.Forester,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.Forest, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                }
            },
            {
                Specialization.Swineherd,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.Forest, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                    new Localization { LocationVisit = LocationVisit.Plain, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                }
            },
            {
                Specialization.Shepherd,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.Forest, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                    new Localization { LocationVisit = LocationVisit.Plain, TypeVisits = new List<TypeVisit> { TypeVisit.Work }, },
                }
            },
            {
                Specialization.Outlaw,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.Forest, TypeVisits = new List<TypeVisit> { TypeVisit.Work, TypeVisit.Home }, },
                    new Localization { LocationVisit = LocationVisit.Plain, TypeVisits = new List<TypeVisit> { TypeVisit.Work, TypeVisit.Home }, },
                }
            },
            {
                Specialization.Scientist,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.Forest, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                    new Localization { LocationVisit = LocationVisit.Plain, TypeVisits = new List<TypeVisit> { TypeVisit.Work, }, },
                }
            },
            {
                Specialization.ItinerantTrader,
                new List<Localization>
                {
                    new Localization { LocationVisit = LocationVisit.Forest, TypeVisits = new List<TypeVisit> { TypeVisit.Road, }, },
                    new Localization { LocationVisit = LocationVisit.Plain, TypeVisits = new List<TypeVisit> { TypeVisit.Road, }, },
                }
            },
        };

        private Random _random = new Random();
        public Person WhoKilled; //Кто убил? 
        public LocationVisit WhereLives; //Где обитает?
        public List<Person> WhoKills; //Кого убил?
        public Dictionary<Person, List<Tuple<PersonsLink, List<PersonAction>>>> Relationships; //Все люди при создании нового сабытия и их взаимосвязи
        public Person WhoArrive;// Кто пришел с плохими вестями?



        public Engine_Reverse(Person _monster)
        {
            WhoKilled = _monster;
            WhoKills = new List<Person>();
            var _persons_could_kill = _locationForPerson.Where(person => person.Value.Select(local => local.LocationVisit).Any(x => _monster.Location.Contains(x))).ToArray();
            var _persons_kill = _persons_could_kill[_random.Next(0, _persons_could_kill.Length)];
            var _location = _monster.Location.Where(x => _persons_kill.Value.Select(local => local.LocationVisit).Contains(x)).ToArray();
            WhereLives = _location[_random.Next(0, _location.Length)];

            WhoKills.Add(new Person
            {
                Name = $"unknow_agent",
                Location = new List<LocationVisit> { WhereLives },
                Specialization = _persons_kill.Key,
                Characteristics = Characteristic.AllCharacteristics.Select((typeCharacter, pos) => typeCharacter.Value[_random.Next(typeCharacter.Value.Count)]).ToList()
            });

            var isCoupleInLove = _random.Next(0, 100) < 20;
            if (isCoupleInLove) // Влюбленная парочка?
            {
                WhoKills.Add(new Person
                {
                    Name = $"girlfrand_for_unknow_agent",
                    Location = new List<LocationVisit> { WhereLives },
                    Specialization = Specialization.Courtesan,
                    Characteristics = Characteristic.AllCharacteristics.Select((typeCharacter, pos) => typeCharacter.Value[_random.Next(typeCharacter.Value.Count)]).ToList()
                });
            }

            Relationships = new Dictionary<Person, List<Tuple<PersonsLink, List<PersonAction>>>>();


            // Кто рассказал о случившимся?
            var isBeInPlace = _random.Next(0, 100) > 50;

            var _listPersonsBeInPlace = _locationForPerson.Where(person => person.Value.Select(local => local.LocationVisit).Any(x => x == WhereLives)).ToArray();
            var _personBeInPlace = _listPersonsBeInPlace[_random.Next(0, _listPersonsBeInPlace.Length)];

            var _listEvents = new EventAction[] { EventAction.Watch, EventAction.Heard, EventAction.Helped, };
            var _eventAction = _listEvents[_random.Next(0, _listEvents.Length)];

            var p = new Person
            {
                Name = $"unknow_agent_Passer_",
                Location = new List<LocationVisit> { WhereLives },
                Specialization = _personBeInPlace.Key,
                Characteristics = Characteristic.AllCharacteristics.Select((typeCharacter, pos) => typeCharacter.Value[_random.Next(typeCharacter.Value.Count)]).ToList()
            };

            Relationships.Add(
                p,
                new List<Tuple<PersonsLink, List<PersonAction>>>
                {
                        Tuple.Create(
                            new PersonsLink
                            {
                                Persons = WhoKills,
                                Relationships = new List<Relationship> { Relationship.Passer }
                            },
                            new List<PersonAction>
                            {
                                new PersonAction { Action = _eventAction, ActionPerson = new List<Person> { p }, ObservedPersons = WhoKills }
                            })
                });

            if (isBeInPlace) //Был на мест?
            {
                WhoArrive = p;
            }
            else
            {
                var num_person_level = _random.Next(1, 3);
                var _list = new List<EventAction> { EventAction.Worried, EventAction.Searching, EventAction.HeardTheTalk, };
                var lastEvent = _list[_random.Next(0, _list.Count)];

                var _person = p;
                var spec = Specialization.Outlaw;
                var p_temp = default(Person);
                for (int i = 0; i < num_person_level; ++i)
                {
                    spec = (Specialization)_random.Next(0, Enum.GetValues(typeof(Specialization)).Length);                    
                    p_temp = new Person
                    {
                        Name = $"unknow_agent_Passer{i}",
                        Location = new List<LocationVisit> { _locationForPerson[spec][_random.Next(0, _locationForPerson[spec].Count)].LocationVisit },
                        Specialization = spec,
                        Characteristics = Characteristic.AllCharacteristics.Select((typeCharacter, pos) => typeCharacter.Value[_random.Next(typeCharacter.Value.Count)]).ToList()
                    };

                    Relationships.Add(
                        p_temp,
                        new List<Tuple<PersonsLink, List<PersonAction>>>
                        {
                        Tuple.Create(
                            new PersonsLink
                            {
                                Persons = new List<Person> { _person },
                                Relationships = new List<Relationship> { Relationship.Passer }
                            },
                            new List<PersonAction>
                            {
                                new PersonAction { Action = EventAction.HeardTheTalk, ActionPerson = new List<Person> { p_temp }, ObservedPersons = new List<Person>{ _person } }
                            })
                        });

                    _person = p_temp;
                }



                if (lastEvent != EventAction.HeardTheTalk)
                {
                    var listSpec = new List<Specialization> { Specialization.TavernKeeper, Specialization.Warder, Specialization.ChiefGuard, };
                    spec = listSpec[_random.Next(0, listSpec.Count)];
                    var previousLast_p = new Person
                    {
                        Name = $"unknow_agent_previousLast",
                        Location = new List<LocationVisit> { _locationForPerson[spec][_random.Next(0, _locationForPerson[spec].Count)].LocationVisit },
                        Specialization = spec,
                        Characteristics = Characteristic.AllCharacteristics.Select((typeCharacter, pos) => typeCharacter.Value[_random.Next(typeCharacter.Value.Count)]).ToList()
                    };

                    Relationships.Add(
                        previousLast_p,
                        new List<Tuple<PersonsLink, List<PersonAction>>>
                        {
                        Tuple.Create(
                            new PersonsLink
                            {
                                Persons = new List<Person> { _person },
                                Relationships = new List<Relationship> { Relationship.Passer }
                            },
                            new List<PersonAction>
                            {
                                new PersonAction { Action = EventAction.HeardTheTalk, ActionPerson = new List<Person> { previousLast_p }, ObservedPersons = new List<Person>{ _person } }
                            })
                        });

                    _person = previousLast_p;
                }


                spec = (Specialization)_random.Next(0, Enum.GetValues(typeof(Specialization)).Length);
                var last_p = new Person
                {
                    Name = $"unknow_agent_Last",
                    Location = new List<LocationVisit> { _locationForPerson[spec][_random.Next(0, _locationForPerson[spec].Count)].LocationVisit },
                    Specialization = spec,
                    Characteristics = Characteristic.AllCharacteristics.Select((typeCharacter, pos) => typeCharacter.Value[_random.Next(typeCharacter.Value.Count)]).ToList()
                };

                Relationships.Add(
                    last_p,
                    new List<Tuple<PersonsLink, List<PersonAction>>>
                    {
                        Tuple.Create(
                            new PersonsLink
                            {
                                Persons = new List<Person> { _person },
                                Relationships = new List<Relationship>{ (Relationship)_random.Next(0, Enum.GetValues(typeof(Relationship)).Length) }
                            },
                            new List<PersonAction>
                            {
                                new PersonAction { Action = lastEvent, ActionPerson = new List<Person> { last_p }, ObservedPersons =  new List<Person>{ _person } }
                            })
                    });
                WhoArrive = last_p;
            }
        }
    }

    public enum LocationVisit
    {
        Plain, //Равнина
        Forest, //Лес
        Mountains, //Горы
        Swamp, //Болото
        MountainForest, //Горный лес
        AbandonedSettlement,  //Заброшенное поселение
        Ruin, //Руины
        WaterMeadowByRiver, //Заливной луг у реки
        SmoulderingRuins, //Пепелище
        Caves, //Пещеры
        RuinsInCaves, //Руины в пещерах
        MunicipalSewerage, //Городская канализация
        CityIndustrialZone, //Городская промзона
        UrbanResidentialArea_Poor, //Городской жилой район (бедный) 
        UrbanResidentialArea_Rich, //Городской жилой район (богатый) 
        CityOutpost_WithPrison, //Городская застава (с тюрьмой)
        VegetableGardens_OutsideCity, //Огороды горожан (вне города)
        CitizensFields_OutsideTheCity, //Поля горожан (вне города)
        Village, //Деревня
    }

    public class PersonsLink
    {
        public List<Person> Persons;
        public List<Relationship> Relationships;
    }

    public class PersonAction
    {
        public List<Person> ActionPerson;
        public List<Person> ObservedPersons;
        public EventAction Action;
    }

    public enum Relationship
    {
        Grandmother, Wife, Daughter, Girlfriend, Bride,
        Grandfather, Husband, Son, Friend, Suitor,
        Employee, Boss, Colleague,
        Passer
    }

    public enum EventAction
    {
        Watch, //Видел
        Worried, //Переживает,
        Searching, //Ищет,
        Heard, //Слыщал,
        Told, //Рассказал,
        HeardTheTalk, //СлышарРазговоры,
        DoesNotKnow, //Незнает,
        Helped, //Помогал,
    }


    public enum Specialization
    {
        Hunter, //Охотник	
        Mason, //Каменщик
        Woodcutter, //Лесоруб
        TavernKeeper, //Тавернщик
        Courtesan, //Куртизанка
        Warder, //Стражник
        Imperial, //Имперский
        Marshal, //Маршал
        Judge, //Судья
        ChiefGuard, //Начальник стражи
        OfficerGuard, //Офицер стражи
        Jailer, //Тюремщик
        LocalGovernor, //Местный воевода
        Bard, //Бард
        Forester, //Лесничий
        Swineherd, //Свинопас
        Shepherd, //Пастух
        Outlaw, //Разбойник
        Scientist, //Учёный
        ItinerantTrader, //Странствующий торговец
    }

    public enum TypeVisit    
    {
        Home,
        Work,
        Road
    }

    public class Localization
    {
        public LocationVisit LocationVisit;
        public List<TypeVisit> TypeVisits;
    }
}
