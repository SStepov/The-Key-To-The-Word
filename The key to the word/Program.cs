using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace The_key_to_the_word
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            bool isOpenMenu = true;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Добро пожаловать в игру: Ключь к слову");
            Console.WriteLine("Рады вас видеть у нас!\n");
            Console.ResetColor();
            while (isOpen)
            {
                Console.WriteLine("Доступные команды:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔═════════════════\n" +
                                  "╠ Начать/старт - начать/запустить игру\n" +
                                  "╠ Информация/инфо - информация о игре\n" +
                                  "╠ Выйти - выход с игры\n" +
                                  "╚═════════════════");
                Console.ResetColor();
                Console.Write("Команда: ");
                Console.ForegroundColor = ConsoleColor.Red;
                string cmd = Console.ReadLine().ToLower();
                Console.ResetColor();

                switch (cmd)
                {
                    case "начать":
                    case "старт":
                        while (isOpenMenu)
                        {
                            Console.Clear();
                            Console.WriteLine("Добро пожаловать в меню!");
                            Console.WriteLine("Доступные уровни сложности:");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("╔═════════════════");
                            Console.Write("╠ ");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Легкий(Lite)");
                            Console.ResetColor();
                            Console.WriteLine(" - очень легко");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("╠ ");

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Нормальный(Normal)");
                            Console.ResetColor();
                            Console.WriteLine(" - придется подумать");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("╠ ");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Сложный(Hard)");
                            Console.ResetColor();
                            Console.WriteLine(" - никак не отгадать");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("╠ ");

                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write("Выйти(Exit)");
                            Console.ResetColor();
                            Console.WriteLine(" - выйти с игры");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("╚═════════════════");
                            Console.ResetColor();
                            Console.Write("Ваш выбор: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            cmd = Console.ReadLine().ToLower();
                            Console.ResetColor();
                            switch (cmd)
                            {
                                case "легкий":
                                case "lite":
                                    Lite();
                                    break;
                                case "нормальный":
                                case "normal":
                                    Normal();
                                    break;
                                case "сложный":
                                case "hard":
                                    Hard();
                                    break;
                                case "выйти":
                                case "exit":
                                    ExitGame();
                                    isOpenMenu = false;
                                    isOpen = false;
                                    break;
                                default:
                                    Error();
                                    break;
                            }
                        }
                        break;

                    case "информация":
                    case "инфо":
                        Information();
                        break;

                    case "выйти":

                        ExitGame();
                        isOpen = false;
                        isOpenMenu = false;
                        break;

                    default:

                        Error();

                        break;
                }
            }
        }
        static void Information()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                      Информация о игре                       ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Добро пожаловать в игру 'Ключ к слову'!");
            Console.WriteLine("Это консольная игра, в которой вам предстоит отгадывать слова по загадкам.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Как играть:");
            Console.ResetColor();
            Console.WriteLine("1. Выберите уровень сложности: Легкий, Нормальный или Сложный.");
            Console.WriteLine("2. Вам будет показана загадка. Введите слово, которое, по вашему мнению, является ответом.");
            Console.WriteLine("3. Если ответ правильный, вы перейдете к следующей загадке.");
            Console.WriteLine("4. Если ответ неверный, вы можете попробовать еще раз.");
            Console.WriteLine("5. Вы можете выйти в главное меню в любой момент.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Уровни сложности:");
            Console.ResetColor();
            Console.WriteLine("- Легкий: Простые загадки для новичков. Количество попыток: 10.");
            Console.WriteLine("- Нормальный: Загадки средней сложности, требующие логического мышления. Количество попыток: 5.");
            Console.WriteLine("- Сложный: Самые сложные загадки для настоящих эрудитов. Количество попыток: 3.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Команды:");
            Console.ResetColor();
            Console.WriteLine("- Начать/Старт: Начать игру.");
            Console.WriteLine("- Информация/Инфо: Показать эту информацию.");
            Console.WriteLine("- Выйти: Завершить игру.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Дополнительная информация по сложному уровню");
            Console.ResetColor();
            Console.WriteLine("- Если вы не знаете отгадку на слово, вы можете прописать команду");
            Console.WriteLine("- Команду: 'не знаю'");
            Console.WriteLine("- В таком случае, вам скажут слово и вы сможете вернуться в меню");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Разработчик: SStepov");
            Console.WriteLine("Спасибо за игру! Надеемся, вам понравится!");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в главное меню...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        static void ExitGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Рады были вас видеть!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Разработчик SStepov");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(", очень для вас старался!\n" +
                              "Надеюсь вы к нам вернетесь!");
            Console.ResetColor();
        }
        static void Error()
        {
            Console.Clear();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[Ошибка] ");
            Console.ResetColor();
            Console.WriteLine("Я не понял что вы написали!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[Ошибка] ");
            Console.ResetColor();
            Console.WriteLine("Проверьте ваш ввод, и введите команду по новой.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[Информация] ");
            Console.ResetColor();
            Console.WriteLine("Нажмите любую клавишу для продолжения.");
            Console.ReadKey();
            Console.Clear();
        }
        static void Lite()
        {
            Console.Clear();
            string cmdLite;
            bool isOpenLiteGame = true;
            List<string> wordLite = new List<string>{
        "яблоко", "солнце", "книга", "мяч", "часы",
        "ручка", "стул", "собака", "кошка", "дом",
        "цветок", "молоко", "хлеб", "рыба", "луна",
        "зонт", "снег", "самолёт", "телефон", "ключ" };

            List<string> riddleLite = new List<string>{
        "Круглое, румяное, с дерева упало, к нам на стол попало.", // Яблоко
        "На небе светит ярко, греет всех ребят. Без него на улице холодно и мрак.", // Солнце
        "Не дерево, а с листами, не человек, а рассказывает.", // Книга
        "Его бьют, а он не плачет, только выше прыгать хочет.", // Мяч
        "Без ног, но ходят, без рук, но показывают.", // Часы
        "С ней можно писать, рисовать, но нельзя есть.", // Ручка
        "Четыре ноги, спинка есть, но не бегает и не летает.", // Стул
        "Друг человека, лает, но не говорит.", // Собака
        "Мягкая, пушистая, ловит мышей и мурлычет.", // Кошка
        "Стены, крыша, окна, двери - в нём живут люди и звери.", // Дом
        "Растёт на клумбе, пахнет, но не говорит.", // Цветок
        "Белое, полезное, даёт корова.", // Молоко
        "Мягкий, душистый, на столе главный.", // Хлеб
        "Плавает в воде, но не тонет, имеет плавники, но не птица.", // Рыба
        "Ночью светит, но не греет, на небе видна, но не звезда.", // Луна
        "От дождя защищает, но сам мокнет.", // Зонт
        "Белый, пушистый, зимой падает, летом тает.", // Снег
        "Летит, но не птица, гудит, но не пчела.", // Самолёт
        "Говорит, но не человек, звонит, но не колокольчик.", // Телефон
        "Открывает замок, но не книгу." // Ключ
    };

            while (isOpenLiteGame)
            {
                bool isOpenLiteGuessing = true;

                Random randLite = new Random();
                int indexWordLite = randLite.Next(0, wordLite.Count);
                int indexRiddleLite = indexWordLite;
                while (isOpenLiteGuessing)
                {
                    int attemptLite = 9;
                    for (; attemptLite >= 0; attemptLite--)
                    {
                        if (wordLite.Count == 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[Урааа!] ");
                            Console.ResetColor();
                            Console.WriteLine("Вы отгадали все слова!");

                            Console.WriteLine("Вернемся в меню?\n");

                            Console.WriteLine("Доступные команды:");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("╔═════════════════\n" +
                                              "╠ Да - вернуться в меню\n" +
                                              "╚═════════════════");
                            Console.ResetColor();
                            Console.Write("Команда: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            cmdLite = Console.ReadLine().ToLower();
                            Console.ResetColor();
                            switch (cmdLite)
                            {
                                case "да":
                                    Console.Clear();
                                    isOpenLiteGuessing = false;
                                    break;
                                default:
                                    Error();
                                    break;
                            }
                        }

                        Console.ResetColor();
                        Console.Write("Загадка: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(riddleLite[indexRiddleLite]);
                        Console.ResetColor();
                        Console.Write("Ваш ответ: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        string answerLite = Console.ReadLine().ToLower();
                        Console.ResetColor();

                        if (answerLite == wordLite[indexWordLite])
                        {

                            bool isOpenRightAnswer = true;

                            string rightAnswer = wordLite[indexWordLite];

                            wordLite.RemoveAt(indexWordLite);
                            riddleLite.RemoveAt(indexRiddleLite);

                            while (isOpenRightAnswer)
                            {
                                isOpenLiteGuessing = false;
                                isOpenLiteGame = false;

                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("[Урааа!] ");
                                Console.ResetColor();
                                Console.WriteLine("Вы отгадали слово!");
                                Console.Write("Этим словом было: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{rightAnswer}\n");
                                Console.ResetColor();

                                Console.WriteLine("Доступные команды:");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("╔═════════════════\n" +
                                                  "╠ Попробовать/еще - отгадать другую загадку\n" +
                                                  "╠ Меню - вернуться в меню\n" +
                                                  "╚═════════════════");
                                Console.ResetColor();
                                Console.Write("Команда: ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                cmdLite = Console.ReadLine().ToLower();
                                Console.ResetColor();
                                switch (cmdLite)
                                {
                                    case "попробовать":
                                    case "еще":
                                        Console.Clear();
                                        isOpenRightAnswer = false;
                                        isOpenLiteGuessing = true;
                                        isOpenLiteGame = true;
                                        break;

                                    case "меню":
                                        Console.Clear();
                                        isOpenLiteGame = false;
                                        isOpenLiteGuessing = false;
                                        isOpenRightAnswer = false;
                                        break;

                                    default:
                                        Error();
                                        break;
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[Упс..] ");
                            Console.ResetColor();
                            Console.WriteLine($"Вы не отгадали, попробуйте еще раз. Осталось попыток: {attemptLite}");
                        }
                        string rightAnswerAtt0 = wordLite[indexWordLite];
                        if (attemptLite == 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[Увы!] ");
                            Console.ResetColor();
                            Console.WriteLine("Попытки закончились. Возвращаемся в меню.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[Увы!] ");
                            Console.ResetColor();
                            Console.Write("Этим словом было: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(rightAnswerAtt0);
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[Увы!] ");
                            Console.ResetColor();
                            Console.WriteLine("Нажмите любую клавишу для продолжения.");
                            Console.ReadKey();
                            isOpenLiteGuessing = false;
                            isOpenLiteGame = false;
                        }
                    }
                }
            }
        }
        static void Normal()
        {
            {
                Console.Clear();
                string cmdNormal;
                bool isOpenNormalGame = true;
                List<string> wordNormal = new List<string>{
                "телескоп", "паутина", "вулкан", "компас", "коралл",
                "гроза", "пирамида", "колокол", "факел", "фонарь",
                "мост", "пароль", "маяк", "зеркало", "радуга",
                "ветер", "секундомер", "глобус", "океан", "гора" };

                List<string> riddleNormal = new List<string>{
                "В ночи я глаз, что видит дали, звёзды и планеты вдали. Не птица, но в небо гляжу, кто я, ты уже понял, скажи?", // телескоп
                "Не ткач, но тку я узор, не рыбак, но ловлю я свой улов. В углу я живу, невидимка, кто я, ты отгадай-ка?", // паутина
                "Я сплю, но бывает, проснусь, и пламя из сердца излью. Гора я, но с огнём внутри, кто я, ты уже знаешь, пойми.", // Вулкан
                "Стрелка моя всегда на север, куда бы ты ни пошёл. Без карты, но путь укажу, кто я, ты уже понял, нашёл?", // Компас
                "В воде я живу, но не рыба, на дне я расту, но не водоросль. Красивый, но хрупкий, кто я, отгадай-ка, мой вопрос?", // Коралл
                "Гремит, сверкает, дождь льёт, но это не фейерверк. Природа её создаёт, кто это, ты знаешь, мой урок?", // Гроза
                "В пустыне стою я века, вершиной касаясь небес. Фараонов хранила я, кто я, ты ответил бы сейчас, прогресс?", // Пирамида
                "Звонкий, но не голос, металлический, но не меч. В церкви меня найдёшь, кто я, ты уже знаешь, мой ответ?", // Колокол
                "Горю, но не сгораю, светлю, но не звезда. В руках меня несут, кто я, ты отгадал, всегда?", // Факел
                "Светит, но не солнце, горит, но не костёр. В темноте я помощник, кто я, ты уже понял, мой узор?", // Фонарь
                "Над рекой я стою, но не рыба, соединяю берега, но не лодка. Кто я, ты уже знаешь, моя загадка?", // Мост
                "Не ключ, но открываю, не слово, но важное. Без меня не войти, кто я, ты уже знаешь, отгадай-ка?", // Пароль
                "Стою на краю земли, светом путь указываю. Корабли меня ищут, кто я, ты уже знаешь, признаю?", // Маяк
                "Смотрюсь в него я каждый день, но не вижу лица своего. Отражает всё, что перед ним, кто я, ты знаешь, моё слово?", // Зеркало
                "После дождя я появляюсь, но не солнце. Семь цветов у меня, кто я, ты уже знаешь, мой конец?", // Радуга
                "Невидимый, но сильный, деревья качает, но не руки. Кто я, ты уже понял, мои звуки?", // Ветер
                "Время я меряю, но не часы, бегу, но не спортсмен. Кто я, ты уже знаешь, мой ответ?", // Секундомер
                "Круглый, но не мяч, весь мир на мне виден. Верчусь, но не танцую, кто я, ты отгадал, мой видный?", // Глобус
                "Широкий, глубокий, но не лес, волны его качают, но не ветер. Кто я, ты знаешь, мой ответ?", // Океан
                "Высокая, но не дерево, каменная, но не скульптура. Вершиной касаюсь облаков, кто я, ты уже понял, моя натура?" // Гора
            };
                while (isOpenNormalGame)
                {
                    bool isOpenNormalGuessing = true;

                    Random randNormal = new Random();
                    int indexWordNormal = randNormal.Next(0, wordNormal.Count);
                    int indexRiddleNormal = indexWordNormal;
                    while (isOpenNormalGuessing)
                    {
                        int attemptNormal = 4;
                        for (; attemptNormal >= 0; attemptNormal--)
                        {
                            if (wordNormal.Count == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("[Урааа!] ");
                                Console.ResetColor();
                                Console.WriteLine("Вы отгадали все слова!");

                                Console.WriteLine("Вернемся в меню?\n");

                                Console.WriteLine("Доступные команды:");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("╔═════════════════\n" +
                                                  "╠ Да - вернуться в менюу\n" +
                                                  "╚═════════════════");
                                Console.ResetColor();
                                Console.WriteLine("Команда: ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                cmdNormal = Console.ReadLine().ToLower();
                                Console.ResetColor();
                                switch (cmdNormal)
                                {
                                    case "да":
                                        Console.Clear();
                                        isOpenNormalGuessing = false;
                                        break;
                                    default:
                                        Error();
                                        break;
                                }
                            }
                            Console.ResetColor();
                            Console.Write("Загадка: ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(riddleNormal[indexRiddleNormal]);
                            Console.ResetColor();
                            Console.Write("Ваш ответ: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            string answerNormal = Console.ReadLine().ToLower();
                            Console.ResetColor();
                            if (answerNormal == wordNormal[indexWordNormal])
                            {
                                bool isOpenRightAnswer = true;

                                string rightAnswer = wordNormal[indexWordNormal];

                                wordNormal.RemoveAt(indexWordNormal);
                                riddleNormal.RemoveAt(indexRiddleNormal);

                                while (isOpenRightAnswer)
                                {
                                    isOpenNormalGuessing = false;
                                    isOpenNormalGame = false;

                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("[Урааа!] ");
                                    Console.ResetColor();
                                    Console.WriteLine("Вы отгадали слово!");
                                    Console.Write("Этим словом было: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{rightAnswer}\n");
                                    Console.ResetColor();

                                    Console.WriteLine("Доступные команды:");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("╔═════════════════\n" +
                                                      "╠ Попробовать/еще - отгадать другую загадку\n" +
                                                      "╠ Меню - вернуться в меню\n" +
                                                      "╚═════════════════");
                                    Console.ResetColor();
                                    Console.Write("Команда: ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    cmdNormal = Console.ReadLine().ToLower();
                                    Console.ResetColor();
                                    switch (cmdNormal)
                                    {
                                        case "попробовать":
                                        case "еще":
                                            Console.Clear();
                                            isOpenRightAnswer = false;
                                            isOpenNormalGuessing = true;
                                            isOpenNormalGame = true;
                                            break;

                                        case "меню":

                                            Console.Clear();
                                            isOpenNormalGame = false;
                                            isOpenNormalGuessing = false;
                                            isOpenRightAnswer = false;
                                            break;

                                        default:

                                            Error();

                                            break;
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[Упс..] ");
                                Console.ResetColor();
                                Console.WriteLine($"Вы не отгадали, попробуйте еще раз. Осталось попыток: {attemptNormal}");
                            }
                            string rightAnswerAtt0 = wordNormal[indexWordNormal];
                            if (attemptNormal == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[Увы!] ");
                                Console.ResetColor();
                                Console.WriteLine("Попытки закончились. Возвращаемся в меню.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[Увы!] ");
                                Console.ResetColor();
                                Console.Write("Этим словом было: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(rightAnswerAtt0);
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[Увы!] ");
                                Console.ResetColor();
                                Console.WriteLine("Нажмите любую клавишу для продолжения.");
                                Console.ReadKey();
                                isOpenNormalGuessing = false;
                                isOpenNormalGame = false;
                            }
                        }
                    }
                }
            }
        }
        static void Hard()
        {
            {
                Console.Clear();
                string cmdHard;
                bool isOpenHardGame = true;
                List<string> wordHard = new List<string>{
                "алмаз", "галактика", "иероглиф", "квант", "лабиринт",
                "молния", "оазис", "парфюм", "радар", "сфинкс",
                "торнадо", "ураган", "феникс", "хронос", "цунами",
                "чернила", "шахматы", "эхо", "юпитер", "якорь" };

                List<string> riddleHard = new List<string>{
                "Я рождаюсь под землёй, в огне и давлении. Блещу, но не золото, твёрдый, но не сталь. Кто я?", // Алмаз
                "Миллиарды звёзд во мне живут, но я не небо. Вращаюсь, но не планета, огромная, но не вселенная. Кто я?", // Галактика
                "Я не буква, но пишу, не картина, но рисую. Древний смысл во мне скрыт, кто я, ты отгадай?", // Иероглиф
                "Я частица, но не пыль, энергия, но не свет. В мире малого я царь, кто я, дай ответ.", // квант
                "Я путь, но не дорога, запутанный, но не сеть. Выход ищу, но не найду, кто я, ты уже понял?", // Лабиринт
                "Я свет, но не фонарь, быстрая, но не пуля. Гром мой спутник, кто я, ты знаешь?", // Молния
                "В пустыне я островок, но не земля. Вода во мне, но не море, кто я, отгадай?", // Оазис
                "Я аромат, но не цветок, жидкость, но не вода. В бутылке живу, кто я, ты знаешь?", // Парфюм
                "Я вижу, но не глаза, волны ловлю, но не рыба. В небе и море помощник, кто я, ты понял?", // Радар
                "Я зверь, но не живой, загадки задаю, но не человек. В песках я стою, кто я, ты знаешь?", // Сфинкс
                "Я ветер, но не бриз, разрушаю, но не война. Воронка моя форма, кто я, ты понял?", // Торнадо
                "Я шторм, но не дождь, сильный, но не ветер. Имя мне дали люди, кто я, ты знаешь?", // Ураган
                "СЯ птица, но не живая, из пепла рождаюсь, но не человек. Вечный символ, кто я, ты понял?", // Феникс
                "Я время, но не часы, бегу, но не спортсмен. Всё меня боится, кто я, ты знаешь?", // Хронос
                "Я волна, но не море, разрушаю, но не война. Рождаюсь в глубинах, кто я, ты понял?", // Цунами
                "Я жидкость, но не вода, пишу, но не ручка. Вечность во мне, кто я, ты знаешь?", // Чернила
                "Я игра, но не карты, фигуры во мне, но не театр. Короли мне подвластны, кто я, ты понял?", // Шахматы
                "Я звук, но не голос, повторяю, но не попугай. В горах меня найдёшь, кто я, ты знаешь?", // Эха
                "Я планета, но не Земля, большой, но не Солнце. Газовый гигант, кто я, ты понял?", // Юпитер
                "Я тяжёлый, но не груз, держу, но не руки. В море я помощник, кто я, ты знаешь?" // Якорь
            };
                while (isOpenHardGame)
                {

                    bool isOpenHardGuessing = true;

                    Random randHard = new Random();
                    int indexWordHard = randHard.Next(0, wordHard.Count);
                    int indexRiddleHard = indexWordHard;

                    while (isOpenHardGuessing)
                    {
                        int attemptHard = 2;
                        for (; attemptHard >= 0; attemptHard--)
                        {
                            if (wordHard.Count == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("[Урааа!] ");
                                Console.ResetColor();
                                Console.WriteLine("Вы отгадали все слова!");

                                Console.WriteLine("Вернемся в меню?\n");

                                Console.WriteLine("Доступные команды:");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("╔═════════════════\n" +
                                                  "╠ Да - вернуться в менюу\n" +
                                                  "╚═════════════════");
                                Console.ResetColor();
                                Console.WriteLine("Команда: ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                cmdHard = Console.ReadLine().ToLower();
                                Console.ResetColor();
                                switch (cmdHard)
                                {
                                    case "да":
                                        Console.Clear();
                                        isOpenHardGuessing = false;
                                        break;
                                    default:
                                        Error();
                                        break;
                                }
                            }
                            Console.ResetColor();
                            Console.Write("Загадка: ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(riddleHard[indexRiddleHard]);
                            Console.ResetColor();
                            Console.Write("Ваш ответ: ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            string answerHard = Console.ReadLine().ToLower();
                            Console.ResetColor();
                            string rightAnswer = wordHard[indexWordHard];
                            if (answerHard != wordHard[indexWordHard])
                            {
                                Console.SetCursorPosition(0, 0);
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[Упс..] ");
                                Console.ResetColor();
                                Console.WriteLine($"Вы не отгадали, попробуйте еще раз. Осталось попыток: {attemptHard}");
                            }
                            if (answerHard == wordHard[indexWordHard])
                            {
                                bool isOpenRightAnswer = true;

                                wordHard.RemoveAt(indexWordHard);
                                riddleHard.RemoveAt(indexRiddleHard);

                                while (isOpenRightAnswer)
                                {
                                    isOpenHardGuessing = false;
                                    isOpenHardGame = false;

                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("[Урааа!] ");
                                    Console.ResetColor();
                                    Console.WriteLine("Вы отгадали слово!");
                                    Console.Write("Этим словом было: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{rightAnswer}\n");
                                    Console.ResetColor();

                                    Console.WriteLine("Доступные команды:");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("╔═════════════════\n" +
                                                      "╠ Попробовать/еще - отгадать другую загадку\n" +
                                                      "╠ Меню - вернуться в меню\n" +
                                                      "╚═════════════════");
                                    Console.ResetColor();
                                    Console.Write("Команда: ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    cmdHard = Console.ReadLine().ToLower();
                                    Console.ResetColor();
                                    switch (cmdHard)
                                    {
                                        case "попробовать":
                                        case "еще":

                                            Console.Clear();
                                            isOpenRightAnswer = false;
                                            isOpenHardGuessing = true;
                                            isOpenHardGame = true;

                                            break;

                                        case "меню":

                                            Console.Clear();
                                            isOpenHardGame = false;
                                            isOpenHardGuessing = false;
                                            isOpenRightAnswer = false;

                                            break;

                                        default:

                                            Error();

                                            break;
                                    }
                                }
                                break;
                            }
                            if (answerHard == "не знаю")
                            {
                                bool IDKhard = true;
                                wordHard.RemoveAt(indexWordHard);
                                riddleHard.RemoveAt(indexRiddleHard);
                                while (IDKhard)
                                {
                                    Console.SetCursorPosition(0, 0);
                                    Console.Clear();
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("[Упс...] ");
                                    Console.ResetColor();
                                    Console.WriteLine("Вы не отгадали слово!");
                                    Console.Write("Этим словом было: ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"{rightAnswer}\n");
                                    Console.ResetColor();

                                    Console.WriteLine("Доступные команды:");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("╔═════════════════\n" +
                                                      "╠ Меню - вернуться в меню\n" +
                                                      "╚═════════════════");
                                    Console.ResetColor();
                                    Console.Write("Команда: ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    cmdHard = Console.ReadLine().ToLower();
                                    Console.ResetColor();
                                    switch (cmdHard)
                                    {
                                        case "меню":
                                            Console.Clear();
                                            isOpenHardGame = false;
                                            isOpenHardGuessing = false;
                                            IDKhard = false;
                                            break;
                                        default:
                                            Error();
                                            break;
                                    }
                                }
                                break;
                            }
                            string rightAnswerAtt0 = wordHard[indexWordHard];
                            if (attemptHard == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[Увы!] ");
                                Console.ResetColor();
                                Console.WriteLine("Попытки закончились. Возвращаемся в меню.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[Увы!] ");
                                Console.ResetColor();
                                Console.Write("Этим словом было: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(rightAnswerAtt0);
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("[Увы!] ");
                                Console.ResetColor();
                                Console.WriteLine("Нажмите любую клавишу для продолжения.");
                                Console.ReadKey();
                                isOpenHardGuessing = false;
                                isOpenHardGame = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
