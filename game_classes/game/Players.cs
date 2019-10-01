using System;
using System.Collections.Generic;

namespace game
{
    public class Players
    {
        public static int NumberOfPlayers()
        {
            Console.WriteLine("Please, enter the number of players:");
            int number = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (number >= 2 && number <= 10)
                {
                    Console.WriteLine("Great, let's start");
                    break;
                }
                else
                {
                    Console.WriteLine("The number of players should be from 2 to 10, try again:");
                    number = Convert.ToInt32(Console.ReadLine());
                }
            }
            return number;
        }

        public static List<string> NamesOfPlayers(int num)
        {
            List<string> players = new List<string>();
            Console.WriteLine("Enter players names:");
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{i + 1} player: ");
                players.Add(Console.ReadLine());
            }
            return (players);
        }
    }
}
