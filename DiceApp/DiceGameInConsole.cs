using System;

namespace DiceApp
{
    class DiceGameInConsole
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to start the program");
            int startCode = Console.ReadLine();
            Random random = new Random();
            int randomNumber = random.Next(0, Convert.ToInt32(startCode);
        }
    }
}
