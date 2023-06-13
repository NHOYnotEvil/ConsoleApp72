namespace ConsoleApp72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float silverToGold = 100;
            float silverToCrystals = 10000;
            float goldToSilver = 1f / 100;
            float goldToCrystals = 100;
            float crystalsToSilver = 1f / 10000;
            float crystalsToGold = 1f / 100;
            float silver;
            float gold;
            float crystals;
            string userInput;
            float currencyCount;
            bool isUserExit = false;

            Console.WriteLine("Добро пожаловать в банк нашей игры. Тут вы можете обменять свои валюты.");

            Console.Write("Введите баланс серебра:");
            silver = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс золота:");
            gold = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс кристаллов:");
            crystals = Convert.ToSingle(Console.ReadLine());

            while (isUserExit == false)
            {
                const string CommandSilversToGolds = "1";
                const string CommandSilversToCrystals = "2";
                const string CommandGoldsToSilvers = "3";
                const string CommandGoldsToCrystals = "4";
                const string CommandCrystalsToSilvers = "5";
                const string CommandCrystalsToGolds = "6";
                const string CommandExit = "exit";

                Console.WriteLine(CommandSilversToGolds + " - обменять серебро на золото.");
                Console.WriteLine(CommandSilversToCrystals + " - обменять серебро на кристаллы.");
                Console.WriteLine(CommandGoldsToSilvers + " - обменять золото на серебро.");
                Console.WriteLine(CommandGoldsToCrystals + " - обменять золото на кристаллы.");
                Console.WriteLine(CommandCrystalsToSilvers + " - обменять кристаллы на серебро.");
                Console.WriteLine(CommandCrystalsToGolds + " - обменять кристаллы на золото.");
                Console.WriteLine(CommandExit + " - выйти из банка.");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSilversToGolds:
                        Console.WriteLine("Обмен серебра на золото.");
                        Console.Write("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        
                        if (silver >= currencyCount)
                        {
                            silver -= currencyCount;
                            gold += currencyCount / silverToGold;
                        }
                        else
                        {
                            Console.WriteLine("Не хватает серебра.");
                        }
                        break;

                    case CommandSilversToCrystals:
                        Console.WriteLine("Обмен серебра на кристаллы.");
                        Console.Write("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        
                        if (silver >= currencyCount)
                        {
                            silver -= currencyCount;
                            crystals += currencyCount / silverToCrystals;
                        }
                        break;

                    case CommandGoldsToSilvers:
                        Console.WriteLine("Обмен золота на серебро.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        
                        if (gold >= currencyCount)
                        {
                            gold -= currencyCount;
                            silver += currencyCount / goldToSilver;
                        }
                        break;

                    case CommandGoldsToCrystals:
                        Console.WriteLine("Обмен золота на кристаллы.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                        
                        if (gold >= currencyCount)
                        {
                            gold -= currencyCount;
                            crystals += currencyCount / goldToCrystals;
                        }
                        break;

                    case CommandCrystalsToSilvers:
                        Console.WriteLine("Обмен кристаллов на серебро.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                       
                        if (crystals >= currencyCount)
                        {
                            crystals -= currencyCount;
                            silver += currencyCount / crystalsToSilver;
                        }
                        break;

                    case CommandCrystalsToGolds:
                        Console.WriteLine("Обмен кристаллов на золото.");
                        Console.WriteLine("Сколько вы хотите обменять:");
                        currencyCount = Convert.ToSingle(Console.ReadLine());
                       
                        if (crystals >= currencyCount)
                        {
                            crystals -= currencyCount;
                            gold += currencyCount / crystalsToGold;
                        }
                        break;

                    case CommandExit:
                        isUserExit = true;
                        break;
                }

                Console.WriteLine("Ваш балланс: " + silver + " серебра, " + gold + " золота, " + crystals + " кристаллов.");
            }
        }
    }
}