using System;

namespace bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Console.WriteLine("Initial array:");
            Reading(numbers);
            Sorting(numbers);
            Writing(numbers);
         }
        static void Reading(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 100);
                Console.Write($"{numbers[i]} ");
            }
        }
        static void Sorting(int[] numbers)
        {
            int temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }

            }
        }
        static void Writing(int[] numbers)
        {
            Console.WriteLine("\nSorted array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }

    }
}
