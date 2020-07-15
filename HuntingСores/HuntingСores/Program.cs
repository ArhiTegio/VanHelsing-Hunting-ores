using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryFastDecisions;
using static System.Console;

namespace HuntingСores
{
    class Program
    {
        public static List<Person> _monsters = new List<Person>
        {
            new Person {
                Name = "Анималии",
                Characteristics = new List<Characteristic>
                {
                    new Characteristic(TypeCharacteristic.Size, NameCharacteristic.Size_Half),
                    new Characteristic(TypeCharacteristic.Attraction, NameCharacteristic.Attraction_Light),
                    new Characteristic(TypeCharacteristic.Inhabitancy, NameCharacteristic.Inhabitancy_Plain),
                    new Characteristic(TypeCharacteristic.Social, NameCharacteristic.Social_Loner),
                    new Characteristic(TypeCharacteristic.Weak, NameCharacteristic.Weak_ThinLeg),
                    new Characteristic(TypeCharacteristic.WeakMetal, NameCharacteristic.WeakMetal_Silver),
                } },

            new Person {
                Name = "Менталии",
                Characteristics = new List<Characteristic>
                {
                    new Characteristic(TypeCharacteristic.Size, NameCharacteristic.Size_Abreast),
                    new Characteristic(TypeCharacteristic.Attraction, NameCharacteristic.Attraction_LoudSound),
                    new Characteristic(TypeCharacteristic.Inhabitancy, NameCharacteristic.Inhabitancy_Forest),
                    new Characteristic(TypeCharacteristic.Social, NameCharacteristic.Social_Famely),
                    new Characteristic(TypeCharacteristic.Weak, NameCharacteristic.Weak_ManeBack),
                    new Characteristic(TypeCharacteristic.WeakMetal, NameCharacteristic.WeakMetal_Acid),

                } },

            new Person {
                Name = "Спиритуалии",
                Characteristics = new List<Characteristic>
                {
                    new Characteristic(TypeCharacteristic.Size, NameCharacteristic.Size_Double),
                    new Characteristic(TypeCharacteristic.Attraction, NameCharacteristic.Attraction_FlowingWater),
                    new Characteristic(TypeCharacteristic.Inhabitancy, NameCharacteristic.Inhabitancy_Mountains),
                    new Characteristic(TypeCharacteristic.Social, NameCharacteristic.Social_Group),
                    new Characteristic(TypeCharacteristic.Weak, NameCharacteristic.Weak_GoiterThroat),
                    new Characteristic(TypeCharacteristic.WeakMetal, NameCharacteristic.WeakMetal_Gold),
                } },

            new Person {
                Name = "Паразиталии",
                Characteristics = new List<Characteristic>
                {
                    new Characteristic(TypeCharacteristic.Size, NameCharacteristic.Size_Gigant),
                    new Characteristic(TypeCharacteristic.Attraction, NameCharacteristic.Attraction_SmellHunter),
                    new Characteristic(TypeCharacteristic.Inhabitancy, NameCharacteristic.Inhabitancy_Swamp),
                    new Characteristic(TypeCharacteristic.Social, NameCharacteristic.Social_Have),
                    new Characteristic(TypeCharacteristic.WeakMetal, NameCharacteristic.Weak_Water),
                    new Characteristic(TypeCharacteristic.WeakMetal, NameCharacteristic.WeakMetal_Wood),
                } },
        };

        private static Dictionary<TypeCharacteristic, Dictionary<Danger, List<string>>> _textsEventsHuntingToMonster = new Dictionary<TypeCharacteristic, Dictionary<Danger, List<string>>>
        {
            { TypeCharacteristic.Attraction, new Dictionary<Danger, List<string>>
            {
                { 
                    Danger.VeryLow, 
                    new List<string> 
                    {
                        "Случилось неожиданное событие Attraction. VeryLow - 1",
                        "Случилось неожиданное событие Attraction. VeryLow - 2",
                        "Случилось неожиданное событие Attraction. VeryLow - 3",
                        "Случилось неожиданное событие Attraction. VeryLow - 4",
                        "Случилось неожиданное событие Attraction. VeryLow - 5",
                    } 
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "Случилось неожиданное событие Attraction. Low - 1",
                        "Случилось неожиданное событие Attraction. Low - 2",
                        "Случилось неожиданное событие Attraction. Low - 3",
                        "Случилось неожиданное событие Attraction. Low - 4",
                        "Случилось неожиданное событие Attraction. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "Случилось неожиданное событие Attraction. Average - 1",
                        "Случилось неожиданное событие Attraction. Average - 2",
                        "Случилось неожиданное событие Attraction. Average - 3",
                        "Случилось неожиданное событие Attraction. Average - 4",
                        "Случилось неожиданное событие Attraction. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "Случилось неожиданное событие Attraction. High - 1",
                        "Случилось неожиданное событие Attraction. High - 2",
                        "Случилось неожиданное событие Attraction. High - 3",
                        "Случилось неожиданное событие Attraction. High - 4",
                        "Случилось неожиданное событие Attraction. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "Случилось неожиданное событие Attraction. VeryHigh - 1",
                        "Случилось неожиданное событие Attraction. VeryHigh - 2",
                        "Случилось неожиданное событие Attraction. VeryHigh - 3",
                        "Случилось неожиданное событие Attraction. VeryHigh - 4",
                        "Случилось неожиданное событие Attraction. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Случилось неожиданное событие Attraction. KnowHabitat - 1",
                        "Случилось неожиданное событие Attraction. KnowHabitat - 2",
                        "Случилось неожиданное событие Attraction. KnowHabitat - 3",
                        "Случилось неожиданное событие Attraction. KnowHabitat - 4",
                        "Случилось неожиданное событие Attraction. KnowHabitat - 5",
                    }
                },
            } },
            { TypeCharacteristic.Inhabitancy, new Dictionary<Danger, List<string>>
            {
                {
                    Danger.VeryLow,
                    new List<string>
                    {
                        "Случилось неожиданное событие Inhabitancy. VeryLow - 1",
                        "Случилось неожиданное событие Inhabitancy. VeryLow - 2",
                        "Случилось неожиданное событие Inhabitancy. VeryLow - 3",
                        "Случилось неожиданное событие Inhabitancy. VeryLow - 4",
                        "Случилось неожиданное событие Inhabitancy. VeryLow - 5",
                    }
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "Случилось неожиданное событие Inhabitancy. Low - 1",
                        "Случилось неожиданное событие Inhabitancy. Low - 2",
                        "Случилось неожиданное событие Inhabitancy. Low - 3",
                        "Случилось неожиданное событие Inhabitancy. Low - 4",
                        "Случилось неожиданное событие Inhabitancy. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "Случилось неожиданное событие Inhabitancy. Average - 1",
                        "Случилось неожиданное событие Inhabitancy. Average - 2",
                        "Случилось неожиданное событие Inhabitancy. Average - 3",
                        "Случилось неожиданное событие Inhabitancy. Average - 4",
                        "Случилось неожиданное событие Inhabitancy. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "Случилось неожиданное событие Inhabitancy. High - 1",
                        "Случилось неожиданное событие Inhabitancy. High - 2",
                        "Случилось неожиданное событие Inhabitancy. High - 3",
                        "Случилось неожиданное событие Inhabitancy. High - 4",
                        "Случилось неожиданное событие Inhabitancy. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "Случилось неожиданное событие Inhabitancy. VeryHigh - 1",
                        "Случилось неожиданное событие Inhabitancy. VeryHigh - 2",
                        "Случилось неожиданное событие Inhabitancy. VeryHigh - 3",
                        "Случилось неожиданное событие Inhabitancy. VeryHigh - 4",
                        "Случилось неожиданное событие Inhabitancy. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Случилось неожиданное событие Inhabitancy. KnowHabitat - 1",
                        "Случилось неожиданное событие Inhabitancy. KnowHabitat - 2",
                        "Случилось неожиданное событие Inhabitancy. KnowHabitat - 3",
                        "Случилось неожиданное событие Inhabitancy. KnowHabitat - 4",
                        "Случилось неожиданное событие Inhabitancy. KnowHabitat - 5",
                    }
                },
            } },
            { TypeCharacteristic.Size, new Dictionary<Danger, List<string>>
            {
                {
                    Danger.VeryLow,
                    new List<string>
                    {
                        "Случилось неожиданное событие Size. VeryLow - 1",
                        "Случилось неожиданное событие Size. VeryLow - 2",
                        "Случилось неожиданное событие Size. VeryLow - 3",
                        "Случилось неожиданное событие Size. VeryLow - 4",
                        "Случилось неожиданное событие Size. VeryLow - 5",
                    }
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "Случилось неожиданное событие Size. Low - 1",
                        "Случилось неожиданное событие Size. Low - 2",
                        "Случилось неожиданное событие Size. Low - 3",
                        "Случилось неожиданное событие Size. Low - 4",
                        "Случилось неожиданное событие Size. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "Случилось неожиданное событие Size. Average - 1",
                        "Случилось неожиданное событие Size. Average - 2",
                        "Случилось неожиданное событие Size. Average - 3",
                        "Случилось неожиданное событие Size. Average - 4",
                        "Случилось неожиданное событие Size. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "Случилось неожиданное событие Size. High - 1",
                        "Случилось неожиданное событие Size. High - 2",
                        "Случилось неожиданное событие Size. High - 3",
                        "Случилось неожиданное событие Size. High - 4",
                        "Случилось неожиданное событие Size. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "Случилось неожиданное событие Size. VeryHigh - 1",
                        "Случилось неожиданное событие Size. VeryHigh - 2",
                        "Случилось неожиданное событие Size. VeryHigh - 3",
                        "Случилось неожиданное событие Size. VeryHigh - 4",
                        "Случилось неожиданное событие Size. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Случилось неожиданное событие Size. KnowHabitat - 1",
                        "Случилось неожиданное событие Size. KnowHabitat - 2",
                        "Случилось неожиданное событие Size. KnowHabitat - 3",
                        "Случилось неожиданное событие Size. KnowHabitat - 4",
                        "Случилось неожиданное событие Size. KnowHabitat - 5",
                    }
                },
            } },
            { TypeCharacteristic.Social, new Dictionary<Danger, List<string>>
            {
                {
                    Danger.VeryLow,
                    new List<string>
                    {
                        "Случилось неожиданное событие Social. VeryLow - 1",
                        "Случилось неожиданное событие Social. VeryLow - 2",
                        "Случилось неожиданное событие Social. VeryLow - 3",
                        "Случилось неожиданное событие Social. VeryLow - 4",
                        "Случилось неожиданное событие Social. VeryLow - 5",
                    }
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "Случилось неожиданное событие Social. Low - 1",
                        "Случилось неожиданное событие Social. Low - 2",
                        "Случилось неожиданное событие Social. Low - 3",
                        "Случилось неожиданное событие Social. Low - 4",
                        "Случилось неожиданное событие Social. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "Случилось неожиданное событие Social. Average - 1",
                        "Случилось неожиданное событие Social. Average - 2",
                        "Случилось неожиданное событие Social. Average - 3",
                        "Случилось неожиданное событие Social. Average - 4",
                        "Случилось неожиданное событие Social. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "Случилось неожиданное событие Social. High - 1",
                        "Случилось неожиданное событие Social. High - 2",
                        "Случилось неожиданное событие Social. High - 3",
                        "Случилось неожиданное событие Social. High - 4",
                        "Случилось неожиданное событие Social. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "Случилось неожиданное событие Social. VeryHigh - 1",
                        "Случилось неожиданное событие Social. VeryHigh - 2",
                        "Случилось неожиданное событие Social. VeryHigh - 3",
                        "Случилось неожиданное событие Social. VeryHigh - 4",
                        "Случилось неожиданное событие Social. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Случилось неожиданное событие Social. KnowHabitat - 1",
                        "Случилось неожиданное событие Social. KnowHabitat - 2",
                        "Случилось неожиданное событие Social. KnowHabitat - 3",
                        "Случилось неожиданное событие Social. KnowHabitat - 4",
                        "Случилось неожиданное событие Social. KnowHabitat - 5",
                    }
                },
            } },
            { TypeCharacteristic.Weak, new Dictionary<Danger, List<string>>
            {
                {
                    Danger.VeryLow,
                    new List<string>
                    {
                        "Случилось неожиданное событие Weak. VeryLow - 1",
                        "Случилось неожиданное событие Weak. VeryLow - 2",
                        "Случилось неожиданное событие Weak. VeryLow - 3",
                        "Случилось неожиданное событие Weak. VeryLow - 4",
                        "Случилось неожиданное событие Weak. VeryLow - 5",
                    }
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "Случилось неожиданное событие Weak. Low - 1",
                        "Случилось неожиданное событие Weak. Low - 2",
                        "Случилось неожиданное событие Weak. Low - 3",
                        "Случилось неожиданное событие Weak. Low - 4",
                        "Случилось неожиданное событие Weak. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "Случилось неожиданное событие Weak. Average - 1",
                        "Случилось неожиданное событие Weak. Average - 2",
                        "Случилось неожиданное событие Weak. Average - 3",
                        "Случилось неожиданное событие Weak. Average - 4",
                        "Случилось неожиданное событие Weak. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "Случилось неожиданное событие Weak. High - 1",
                        "Случилось неожиданное событие Weak. High - 2",
                        "Случилось неожиданное событие Weak. High - 3",
                        "Случилось неожиданное событие Weak. High - 4",
                        "Случилось неожиданное событие Weak. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "Случилось неожиданное событие Weak. VeryHigh - 1",
                        "Случилось неожиданное событие Weak. VeryHigh - 2",
                        "Случилось неожиданное событие Weak. VeryHigh - 3",
                        "Случилось неожиданное событие Weak. VeryHigh - 4",
                        "Случилось неожиданное событие Weak. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Случилось неожиданное событие Weak. KnowHabitat - 1",
                        "Случилось неожиданное событие Weak. KnowHabitat - 2",
                        "Случилось неожиданное событие Weak. KnowHabitat - 3",
                        "Случилось неожиданное событие Weak. KnowHabitat - 4",
                        "Случилось неожиданное событие Weak. KnowHabitat - 5",
                    }
                },
            } },
            { TypeCharacteristic.WeakMetal, new Dictionary<Danger, List<string>>
            {
                {
                    Danger.VeryLow,
                    new List<string>
                    {
                        "Случилось неожиданное событие WeakMetal. VeryLow - 1",
                        "Случилось неожиданное событие WeakMetal. VeryLow - 2",
                        "Случилось неожиданное событие WeakMetal. VeryLow - 3",
                        "Случилось неожиданное событие WeakMetal. VeryLow - 4",
                        "Случилось неожиданное событие WeakMetal. VeryLow - 5",
                    }
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "Случилось неожиданное событие WeakMetal. Low - 1",
                        "Случилось неожиданное событие WeakMetal. Low - 2",
                        "Случилось неожиданное событие WeakMetal. Low - 3",
                        "Случилось неожиданное событие WeakMetal. Low - 4",
                        "Случилось неожиданное событие WeakMetal. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "Случилось неожиданное событие WeakMetal. Average - 1",
                        "Случилось неожиданное событие WeakMetal. Average - 2",
                        "Случилось неожиданное событие WeakMetal. Average - 3",
                        "Случилось неожиданное событие WeakMetal. Average - 4",
                        "Случилось неожиданное событие WeakMetal. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "Случилось неожиданное событие WeakMetal. High - 1",
                        "Случилось неожиданное событие WeakMetal. High - 2",
                        "Случилось неожиданное событие WeakMetal. High - 3",
                        "Случилось неожиданное событие WeakMetal. High - 4",
                        "Случилось неожиданное событие WeakMetal. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "Случилось неожиданное событие WeakMetal. VeryHigh - 1",
                        "Случилось неожиданное событие WeakMetal. VeryHigh - 2",
                        "Случилось неожиданное событие WeakMetal. VeryHigh - 3",
                        "Случилось неожиданное событие WeakMetal. VeryHigh - 4",
                        "Случилось неожиданное событие WeakMetal. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Случилось неожиданное событие WeakMetal. KnowHabitat - 1",
                        "Случилось неожиданное событие WeakMetal. KnowHabitat - 2",
                        "Случилось неожиданное событие WeakMetal. KnowHabitat - 3",
                        "Случилось неожиданное событие WeakMetal. KnowHabitat - 4",
                        "Случилось неожиданное событие WeakMetal. KnowHabitat - 5",
                    }
                },
            } },
        };

        private static Dictionary<TypeCharacteristic, Dictionary<Danger, List<string>>> _textsNotFindDangerHuntingToMonster = new Dictionary<TypeCharacteristic, Dictionary<Danger, List<string>>>
        {
                      { TypeCharacteristic.Attraction, new Dictionary<Danger, List<string>>
            {
                {
                    Danger.VeryLow,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Attraction. VeryLow - 1",
                        "Вы случайно узнали о существе Attraction. VeryLow - 2",
                        "Вы случайно узнали о существе Attraction. VeryLow - 3",
                        "Вы случайно узнали о существе Attraction. VeryLow - 4",
                        "Вы случайно узнали о существе Attraction. VeryLow - 5",
                    }
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Attraction. Low - 1",
                        "Вы случайно узнали о существе Attraction. Low - 2",
                        "Вы случайно узнали о существе Attraction. Low - 3",
                        "Вы случайно узнали о существе Attraction. Low - 4",
                        "Вы случайно узнали о существе Attraction. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Attraction. Average - 1",
                        "Вы случайно узнали о существе Attraction. Average - 2",
                        "Вы случайно узнали о существе Attraction. Average - 3",
                        "Вы случайно узнали о существе Attraction. Average - 4",
                        "Вы случайно узнали о существе Attraction. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Attraction. High - 1",
                        "Вы случайно узнали о существе Attraction. High - 2",
                        "Вы случайно узнали о существе Attraction. High - 3",
                        "Вы случайно узнали о существе Attraction. High - 4",
                        "Вы случайно узнали о существе Attraction. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Attraction. VeryHigh - 1",
                        "Вы случайно узнали о существе Attraction. VeryHigh - 2",
                        "Вы случайно узнали о существе Attraction. VeryHigh - 3",
                        "Вы случайно узнали о существе Attraction. VeryHigh - 4",
                        "Вы случайно узнали о существе Attraction. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Attraction. KnowHabitat - 1",
                        "Вы случайно узнали о существе Attraction. KnowHabitat - 2",
                        "Вы случайно узнали о существе Attraction. KnowHabitat - 3",
                        "Вы случайно узнали о существе Attraction. KnowHabitat - 4",
                        "Вы случайно узнали о существе Attraction. KnowHabitat - 5",
                    }
                },
            } },
            { TypeCharacteristic.Inhabitancy, new Dictionary<Danger, List<string>>
            {
                {
                    Danger.VeryLow,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Inhabitancy. VeryLow - 1",
                        "Вы случайно узнали о существе Inhabitancy. VeryLow - 2",
                        "Вы случайно узнали о существе Inhabitancy. VeryLow - 3",
                        "Вы случайно узнали о существе Inhabitancy. VeryLow - 4",
                        "Вы случайно узнали о существе Inhabitancy. VeryLow - 5",
                    }
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Inhabitancy. Low - 1",
                        "Вы случайно узнали о существе Inhabitancy. Low - 2",
                        "Вы случайно узнали о существе Inhabitancy. Low - 3",
                        "Вы случайно узнали о существе Inhabitancy. Low - 4",
                        "Вы случайно узнали о существе Inhabitancy. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Inhabitancy. Average - 1",
                        "Вы случайно узнали о существе Inhabitancy. Average - 2",
                        "Вы случайно узнали о существе Inhabitancy. Average - 3",
                        "Вы случайно узнали о существе Inhabitancy. Average - 4",
                        "Вы случайно узнали о существе Inhabitancy. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Inhabitancy. High - 1",
                        "Вы случайно узнали о существе Inhabitancy. High - 2",
                        "Вы случайно узнали о существе Inhabitancy. High - 3",
                        "Вы случайно узнали о существе Inhabitancy. High - 4",
                        "Вы случайно узнали о существе Inhabitancy. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Inhabitancy. VeryHigh - 1",
                        "Вы случайно узнали о существе Inhabitancy. VeryHigh - 2",
                        "Вы случайно узнали о существе Inhabitancy. VeryHigh - 3",
                        "Вы случайно узнали о существе Inhabitancy. VeryHigh - 4",
                        "Вы случайно узнали о существе Inhabitancy. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Inhabitancy. KnowHabitat - 1",
                        "Вы случайно узнали о существе Inhabitancy. KnowHabitat - 2",
                        "Вы случайно узнали о существе Inhabitancy. KnowHabitat - 3",
                        "Вы случайно узнали о существе Inhabitancy. KnowHabitat - 4",
                        "Вы случайно узнали о существе Inhabitancy. KnowHabitat - 5",
                    }
                },
            } },
            { TypeCharacteristic.Size, new Dictionary<Danger, List<string>>
            {
                {
                    Danger.VeryLow,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Size. VeryLow - 1",
                        "Вы случайно узнали о существе Size. VeryLow - 2",
                        "Вы случайно узнали о существе Size. VeryLow - 3",
                        "Вы случайно узнали о существе Size. VeryLow - 4",
                        "Вы случайно узнали о существе Size. VeryLow - 5",
                    }
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Size. Low - 1",
                        "Вы случайно узнали о существе Size. Low - 2",
                        "Вы случайно узнали о существе Size. Low - 3",
                        "Вы случайно узнали о существе Size. Low - 4",
                        "Вы случайно узнали о существе Size. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Size. Average - 1",
                        "Вы случайно узнали о существе Size. Average - 2",
                        "Вы случайно узнали о существе Size. Average - 3",
                        "Вы случайно узнали о существе Size. Average - 4",
                        "Вы случайно узнали о существе Size. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Size. High - 1",
                        "Вы случайно узнали о существе Size. High - 2",
                        "Вы случайно узнали о существе Size. High - 3",
                        "Вы случайно узнали о существе Size. High - 4",
                        "Вы случайно узнали о существе Size. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Size. VeryHigh - 1",
                        "Вы случайно узнали о существе Size. VeryHigh - 2",
                        "Вы случайно узнали о существе Size. VeryHigh - 3",
                        "Вы случайно узнали о существе Size. VeryHigh - 4",
                        "Вы случайно узнали о существе Size. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Size. KnowHabitat - 1",
                        "Вы случайно узнали о существе Size. KnowHabitat - 2",
                        "Вы случайно узнали о существе Size. KnowHabitat - 3",
                        "Вы случайно узнали о существе Size. KnowHabitat - 4",
                        "Вы случайно узнали о существе Size. KnowHabitat - 5",
                    }
                },
            } },
            { TypeCharacteristic.Social, new Dictionary<Danger, List<string>>
            {
                {
                    Danger.VeryLow,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Social. VeryLow - 1",
                        "Вы случайно узнали о существе Social. VeryLow - 2",
                        "Вы случайно узнали о существе Social. VeryLow - 3",
                        "Вы случайно узнали о существе Social. VeryLow - 4",
                        "Вы случайно узнали о существе Social. VeryLow - 5",
                    }
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Social. Low - 1",
                        "Вы случайно узнали о существе Social. Low - 2",
                        "Вы случайно узнали о существе Social. Low - 3",
                        "Вы случайно узнали о существе Social. Low - 4",
                        "Вы случайно узнали о существе Social. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Social. Average - 1",
                        "Вы случайно узнали о существе Social. Average - 2",
                        "Вы случайно узнали о существе Social. Average - 3",
                        "Вы случайно узнали о существе Social. Average - 4",
                        "Вы случайно узнали о существе Social. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Social. High - 1",
                        "Вы случайно узнали о существе Social. High - 2",
                        "Вы случайно узнали о существе Social. High - 3",
                        "Вы случайно узнали о существе Social. High - 4",
                        "Вы случайно узнали о существе Social. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Social. VeryHigh - 1",
                        "Вы случайно узнали о существе Social. VeryHigh - 2",
                        "Вы случайно узнали о существе Social. VeryHigh - 3",
                        "Вы случайно узнали о существе Social. VeryHigh - 4",
                        "Вы случайно узнали о существе Social. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Social. KnowHabitat - 1",
                        "Вы случайно узнали о существе Social. KnowHabitat - 2",
                        "Вы случайно узнали о существе Social. KnowHabitat - 3",
                        "Вы случайно узнали о существе Social. KnowHabitat - 4",
                        "Вы случайно узнали о существе Social. KnowHabitat - 5",
                    }
                },
            } },
            { TypeCharacteristic.Weak, new Dictionary<Danger, List<string>>
            {
                {
                    Danger.VeryLow,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Weak. VeryLow - 1",
                        "Вы случайно узнали о существе Weak. VeryLow - 2",
                        "Вы случайно узнали о существе Weak. VeryLow - 3",
                        "Вы случайно узнали о существе Weak. VeryLow - 4",
                        "Вы случайно узнали о существе Weak. VeryLow - 5",
                    }
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Weak. Low - 1",
                        "Вы случайно узнали о существе Weak. Low - 2",
                        "Вы случайно узнали о существе Weak. Low - 3",
                        "Вы случайно узнали о существе Weak. Low - 4",
                        "Вы случайно узнали о существе Weak. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Weak. Average - 1",
                        "Вы случайно узнали о существе Weak. Average - 2",
                        "Вы случайно узнали о существе Weak. Average - 3",
                        "Вы случайно узнали о существе Weak. Average - 4",
                        "Вы случайно узнали о существе Weak. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Weak. High - 1",
                        "Вы случайно узнали о существе Weak. High - 2",
                        "Вы случайно узнали о существе Weak. High - 3",
                        "Вы случайно узнали о существе Weak. High - 4",
                        "Вы случайно узнали о существе Weak. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Weak. VeryHigh - 1",
                        "Вы случайно узнали о существе Weak. VeryHigh - 2",
                        "Вы случайно узнали о существе Weak. VeryHigh - 3",
                        "Вы случайно узнали о существе Weak. VeryHigh - 4",
                        "Вы случайно узнали о существе Weak. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Вы случайно узнали о существе Weak. KnowHabitat - 1",
                        "Вы случайно узнали о существе Weak. KnowHabitat - 2",
                        "Вы случайно узнали о существе Weak. KnowHabitat - 3",
                        "Вы случайно узнали о существе Weak. KnowHabitat - 4",
                        "Вы случайно узнали о существе Weak. KnowHabitat - 5",
                    }
                },
            } },
            { TypeCharacteristic.WeakMetal, new Dictionary<Danger, List<string>>
            {
                {
                    Danger.VeryLow,
                    new List<string>
                    {
                        "Вы случайно узнали о существе WeakMetal. VeryLow - 1",
                        "Вы случайно узнали о существе WeakMetal. VeryLow - 2",
                        "Вы случайно узнали о существе WeakMetal. VeryLow - 3",
                        "Вы случайно узнали о существе WeakMetal. VeryLow - 4",
                        "Вы случайно узнали о существе WeakMetal. VeryLow - 5",
                    }
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "Вы случайно узнали о существе WeakMetal. Low - 1",
                        "Вы случайно узнали о существе WeakMetal. Low - 2",
                        "Вы случайно узнали о существе WeakMetal. Low - 3",
                        "Вы случайно узнали о существе WeakMetal. Low - 4",
                        "Вы случайно узнали о существе WeakMetal. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "Вы случайно узнали о существе WeakMetal. Average - 1",
                        "Вы случайно узнали о существе WeakMetal. Average - 2",
                        "Вы случайно узнали о существе WeakMetal. Average - 3",
                        "Вы случайно узнали о существе WeakMetal. Average - 4",
                        "Вы случайно узнали о существе WeakMetal. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "Вы случайно узнали о существе WeakMetal. High - 1",
                        "Вы случайно узнали о существе WeakMetal. High - 2",
                        "Вы случайно узнали о существе WeakMetal. High - 3",
                        "Вы случайно узнали о существе WeakMetal. High - 4",
                        "Вы случайно узнали о существе WeakMetal. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "Вы случайно узнали о существе WeakMetal. VeryHigh - 1",
                        "Вы случайно узнали о существе WeakMetal. VeryHigh - 2",
                        "Вы случайно узнали о существе WeakMetal. VeryHigh - 3",
                        "Вы случайно узнали о существе WeakMetal. VeryHigh - 4",
                        "Вы случайно узнали о существе WeakMetal. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Вы случайно узнали о существе WeakMetal. KnowHabitat - 1",
                        "Вы случайно узнали о существе WeakMetal. KnowHabitat - 2",
                        "Вы случайно узнали о существе WeakMetal. KnowHabitat - 3",
                        "Вы случайно узнали о существе WeakMetal. KnowHabitat - 4",
                        "Вы случайно узнали о существе WeakMetal. KnowHabitat - 5",
                    }
                },
            } },
        };

        private static Dictionary<Danger, List<string>> _textsFindDangerHuntingToMonster = new Dictionary<Danger, List<string>>
        {
            {
                    Danger.VeryLow,
                    new List<string>
                    {
                        "На вас напало существо. VeryLow - 1",
                        "На вас напало существо. VeryLow - 2",
                        "На вас напало существо. VeryLow - 3",
                        "На вас напало существо. VeryLow - 4",
                        "На вас напало существо. VeryLow - 5",
                    }
                },
                {
                    Danger.Low,
                    new List<string>
                    {
                        "На вас напало существо. Low - 1",
                        "На вас напало существо. Low - 2",
                        "На вас напало существо. Low - 3",
                        "На вас напало существо. Low - 4",
                        "На вас напало существо. Low - 5",
                    }
                },
                {
                    Danger.Average,
                    new List<string>
                    {
                        "На вас напало существо. Average - 1",
                        "На вас напало существо. Average - 2",
                        "На вас напало существо. Average - 3",
                        "На вас напало существо. Average - 4",
                        "На вас напало существо. Average - 5",
                    }
                },
                {
                    Danger.High,
                    new List<string>
                    {
                        "На вас напало существо. High - 1",
                        "На вас напало существо. High - 2",
                        "На вас напало существо. High - 3",
                        "На вас напало существо. High - 4",
                        "На вас напало существо. High - 5",
                    }
                },
                {
                    Danger.VeryHigh,
                    new List<string>
                    {
                        "На вас напало существо. VeryHigh - 1",
                        "На вас напало существо. VeryHigh - 2",
                        "На вас напало существо. VeryHigh - 3",
                        "На вас напало существо. VeryHigh - 4",
                        "На вас напало существо. VeryHigh - 5",
                    }
                },
                {
                    Danger.KnowHabitat,
                    new List<string>
                    {
                        "Вы пришли к жилищу существа. KnowHabitat - 1",
                        "Вы пришли к жилищу существа. KnowHabitat - 2",
                        "Вы пришли к жилищу существа. KnowHabitat - 3",
                        "Вы пришли к жилищу существа. KnowHabitat - 4",
                        "Вы пришли к жилищу существа. KnowHabitat - 5",
                    }
                },
        };

        private static Dictionary<TypeCharacteristic, List<string>> _textsInvestigation = new Dictionary<TypeCharacteristic, List<string>>
        {
            { TypeCharacteristic.Attraction, new List<string>
            {
                "Случилось нападение на жертву. Это оказалась женщина. Но это было темная улица по счастливому обстоятельству жертве посчастливилось ускользнуть от погони. По противоречивому ей рассказу, ей запомнились следующие особенности которые привлекло того монстра.",
                "В баре к вам подошел бармен и рассказал очень печальную историю. Утром этого дня случилось убийство. Жертва сопротивлялась до конца но было тщетно. Кто рассказывал про маленького паренька который все это видел, но он был очень далеко чтобы точно сказать кто это было. Ему бросилась несколько особенностей которые привлекли монстра которая может нам помочь. Вы не задумываясь поблагодарили и на всякий случай записали парня в подозреваемые. Все это очень странно.",
                "К вам постучали поздно вечером. Это был молодой парень, он был очень бледен и всклокоченным. Он рассказал, что за ним только что гналась какаето тень по улице пока никого не было на ней. Весь рассказ был сумбурен и но из рассказа вы поняли что в нем привлекло следующая черта. Кто же это мог быть?",
            } },
            { TypeCharacteristic.Size, new List<string>
            {
                "Опять случилось страшное. Но по виду совершенного преступления оно было совершено существом с возможным ростом. Нужно спешить, а то люди уже подозревают и тебя.",
                "На вас была попытка совершить нападение поздно ночью, но вас не было в этой части дома! Остались лишь разбитое окно и пару отпечатком подошвы. Видимо это существо было ростом",
                "Почему вы узнаете все самым последним? Вас окружила толпа людей требующая найти виновного и наказать его. Все рассказывали о виденном в далеке ими. Но у всех были схожие только в ее размере."
            } },
            { TypeCharacteristic.Inhabitancy, new List<string>
            {
                "Вас разбудили поздно ночью. Чтобы вы посмотрели на это существо. Это было издалека и завидев вас оно быстро исчезло в густой чаще. По поведению существа вы показалось, что существо обитало на определенных местности.",
                "Когда вы ходили по городу к вам подошел охранник и рассказал, что сегодня ночью на него напал голодный необычный зверь. Но это было только мгновение и существо быстро ушло не получив свое. Но его по его чутью это существо возможно пришло из ближних земель.",
                "К вам пришли с факелами. Но это не монстры и не сжигать. Это были напуганные жители которые готовы поклясться что видели существо на определенных землях. Что тут творится?? Где тут обещанный тихий домик и курортная атмосфера?"
            } },
            { TypeCharacteristic.Social, new List<string>
            {
                "Про вас уже наслышаны. И видимо не только среди людей. Это была попытка нападения, но вы были неподготовлены и вам пришлось ретироваться.",
                "Ночь не всегда может быть тихой. Вы примчались на крики и звон стали. Но было поздно! Группа счастливых людей уже не с нами.",
                "Сегодня опять совершено нападение. Это было очень хорошо организованно."
            } },
            { TypeCharacteristic.Weak, new List<string>
            {
                "К вам постучались. Это были печальные люди. Они рассказали о недавнем случае. Где жертве не удалось уйти. Но видимо удалось монстра ранить. Почему тут так поздно приходят вести? Здесь нет муравьиной сети?",
                "Бармен сегодня рассказал вам новое происшествие. Это все печально, но он указал что видимо у монстра было одно слабое место. И поэтому жертве удалось спастись. Отличная новость!",
                "Было слишком поздно. Почему же охрана всегда слишком поздно? Вы на месте преступлений осматривая поняли лишь что у монстра видимо есть слабое место."
            } },
            { TypeCharacteristic.WeakMetal, new List<string>
            {
                "Люди после казино не посчастливилось оказаться на улице поздно ночью. Вот что значит употреблять спиртные напитки. Но по видимому одна из монет сильно повредила кожу монстра. Слава к-руким бандитам!",
                "Вы видели сегодня как монстр напал на охранника и это было так стремительно. Но мо монстр ушел как тень в лесу. Но вы запомнили что у охранника было оружие из определенного материала.",
                "К вам подошли беспардонно люди в баре. Потребовали отомстить монстру за их родственника. Это было сегодня ночью. Но они запомнили что монстр испугался определенного орудия в руках у родственника."
            } },
        };



        static void Main(string[] args)
        {
            var _extension = new Extension();
            var _question = new Questions();

            var engine_num = int.Parse(_question.Question<string>(
                        $"Выберите движок игры расследование или охота. (Нажмите 1 или 2)",
                        new HashSet<char> { '1', '2' }, true));

            if (engine_num == 1)
            {
                var engine = new Engine_Investigation(1000, _monsters[(new Random()).Next(0, _monsters.Count - 1)], new Person(), _textsInvestigation);
                while (!engine.IsMonsterFind())
                {
                    _extension.Pause(2000);
                    var step = engine.NextEvent(25);
                    WriteLine(step.Item1);
                    if (step.Item2.Count > 1)
                    {
                        engine.Answer(step.Item2[int.Parse(_question.Question<string>(
                            $"Повидемому это { step.Item2[0].Name } или { step.Item2[1].Name }. (Нажмите 1 или 2)",
                            new HashSet<char> { '1', '2' }, true)) - 1]);
                    }
                    else
                    {
                        WriteLine($"{ step.Item2[0].Name}");
                        engine.Answer(step.Item2[0]);
                    }



                    WriteLine($"Количество подозреваемых { engine.GetSurmise().Count }");
                    WriteLine("Вы {0}", engine.IsMonsterFind() ? "нашли монстра. Поздравляю." : "не нашли еще монстра.");
                }

                WriteLine("!!!");
                _extension.Print("Подготовтесь к взятию монстра.", PositionForRow.LeftEdge, Console.CursorTop + 2);

                _extension.Pause(3000);
            }
            else if (engine_num == 2)
            {
                var engine = new Engine_HuntingToMonster(_monsters[(new Random()).Next(0, _monsters.Count - 1)], 10000, _textsEventsHuntingToMonster, _textsNotFindDangerHuntingToMonster, _textsFindDangerHuntingToMonster);
                var skillPathfinder = 50;
                var luck = 50;

                while (true)
                {
                    _extension.Pause(2000);
                    WriteLine("Случилось событие:");
                    var _event = engine.NextEvent(50);
                    WriteLine(_event);
                    WriteLine($"Возможно событие имеет {engine.GetLevelDanger(luck)} уровень опасности.");

                    var isSearch = int.Parse(_question.Question<string>($"Вы пойдете осматривать место события? (да - 1, нет - 2)",
                            new HashSet<char> { '1', '2' }, true));
                    
                    if(isSearch == 1)
                    {
                        var getState = engine.TryFindMonster(luck, skillPathfinder);

                        if(getState.FindMonster && engine.ChanceDanger == Danger.KnowHabitat)
                        {
                            WriteLine("Вы нашли место обитания монстра!");
                        }

                        WriteLine(getState.Text);

                        if(getState.NewKnowCharact.Name == NameCharacteristic.Unknown)
                        {
                            WriteLine("Вы ничего нового не узнали о существе.");
                        }
                        else
                        {
                            WriteLine($"Вы узнали о существе: {getState.NewKnowCharact.Name}");
                        }
                    }


                    if (engine.IsMonsterHabitatFind())
                    {
                        var isHunting = int.Parse(_question.Question<string>(
                            $"Вы пойдете охотиться на существо? (да - 1, нет - 2)",
                            new HashSet<char> { '1', '2' }, true));
                        if (isHunting == 1) break;
                    }
                }

                WriteLine("!!!");
                _extension.Print("Подготовтесь к охоте на монстра и удачи.", PositionForRow.LeftEdge, Console.CursorTop + 2);

                _extension.Pause(3000);

            }
        }
    }
}
