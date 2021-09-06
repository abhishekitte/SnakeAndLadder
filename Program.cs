using System;

namespace SnakeAndLadder.cs
{
    class SnakeLadder
    {
        //creating a random numberusing Random method()
        public static void CheckDice()
        {
            Random random = new Random();
            int CheckDice = random.Next(1, 6);
            Console.WriteLine("Dice number:" + CheckDice);
        }

        static void Main(string[] args)
        {
            SnakeLadder.CheckDice();
            Console.ReadLine();
        }
    }
}