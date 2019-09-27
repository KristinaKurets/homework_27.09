using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
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
            List<string> names = new List<string>();
            
            Console.WriteLine("Enter players names:");
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{i+1} player: ");
                names.Add(Console.ReadLine());
            }

            string[] quests = File.ReadAllLines("list.txt", Encoding.Default);
            Console.WriteLine("Ok, all player's names are entered.");

            while (true)
            {
                Console.WriteLine("If you want to to see the names of all players, press 'p'; if you want to play, press any key; if you want to end the game, press 'q'");
                string ans = Console.ReadLine();
                if (ans == "q")
                {
                    Console.WriteLine("Bye!");
                    break;
                }
                else if (ans == "p")
                    for (int i = 0; i < number; i++)
                    {
                        Console.WriteLine(names[i]);
                    }

                else Console.WriteLine($"So, {names[rnd.Next(names.Count)]} should {quests[rnd.Next(quests.Length)]}!");
            }
   
        }
    }
}
