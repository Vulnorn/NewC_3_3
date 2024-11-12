using System;
using System.Collections.Generic;

namespace NewC_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lengthArray = 30;
            int minRandomNumbers = 1;
            int maxRandomNumbers = 100;
            int maxLocalNumbers;
            int indexSecondNumber = 1;
            int indexPenultimateNumbers = lengthArray - 2;
            int indexLastNumbers = lengthArray - 1;

            int[] numbers = new int[lengthArray];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomNumbers, maxRandomNumbers);
                Console.Write($"{numbers[i]} ");
            }

            Console.Write($"\nВсе локальные максимумы текущего массива: ");

            if (numbers[0] > numbers[1])
                Console.Write($"{numbers[0]}, ");

            for (int i = indexSecondNumber; i < indexLastNumbers; i++)
            {
                maxLocalNumbers = numbers[i];

                if (maxLocalNumbers > numbers[i - 1] && maxLocalNumbers > numbers[i + 1])
                    Console.Write($"{maxLocalNumbers}, ");
            }

            if (numbers[indexLastNumbers] > numbers[indexPenultimateNumbers])
                Console.Write($"{numbers[indexLastNumbers]}");

            Console.ReadKey();
        }
    }
}