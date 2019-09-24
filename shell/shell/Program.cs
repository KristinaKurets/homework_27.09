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

            int step, i, j, temp;

            // Выбор шага
            for (step = numbers.Length / 2; step > 0; step /= 2)
                // Перечисление элементов, которые сортируются на определённом шаге
                for (i = step; i < numbers.Length; i++)
                    // Перестановка элементов внутри подсписка, пока i-тый не будет отсортирован
                    for (j = i - step; j >= 0 && numbers[j] > numbers[j + step]; j -= step)
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + step];
                        numbers[j + step] = temp;
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
