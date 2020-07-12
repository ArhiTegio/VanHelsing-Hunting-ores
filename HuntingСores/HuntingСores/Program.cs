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

        private static Dictionary<TypeCharacteristic, List<string>> _texts = new Dictionary<TypeCharacteristic, List<string>>
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

            var engine = new Engine_Investigation(1000, _monsters[0], new Person(), _texts);

            while(!engine.IsMonsterFind())
            {
                _extension.Pause(3000);
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

            _extension.Pause(2000);
        }
    }
}
