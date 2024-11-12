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
            int indexFirstNumbers = 0;
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

            for (int i = 0; i < numbers.Length; i++)
            {

                if (i == indexFirstNumbers)
                {
                    maxLocalNumbers = numbers[i];

                    if (maxLocalNumbers > numbers[indexSecondNumber])
                        Console.Write($"{maxLocalNumbers}, ");
                }
                else if (i == indexLastNumbers)
                {
                    maxLocalNumbers = numbers[i];

                    if (maxLocalNumbers > numbers[indexPenultimateNumbers])
                        Console.Write($"{maxLocalNumbers}, ");
                }
                else
                {
                    maxLocalNumbers = numbers[i];

                    if (maxLocalNumbers > numbers[i - 1] && maxLocalNumbers > numbers[i + 1])
                        Console.Write($"{maxLocalNumbers}, ");
                }
            }

            Console.ReadKey();
        }
    }
}