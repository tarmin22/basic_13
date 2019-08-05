using System;

namespace basic_13
{
    class Program
    {
        // Print all of the integers from 1 to 255.
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        // Print all of the odd integers from 1 to 255.
        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        // Print all of the numbers from 0 to 255
        public static void PrintSum()
        {
            int sum = new int();
            for (int i = 1; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine("New number: " + i + "Sum: " + sum);

            }
        }
        // Write a function that would iterate through each item of the given integer array and 
        // print each value to the console. 
        public static void LoopArray(int[] numbers)
        {
            int max = new int();
            max = numbers[0];
            foreach (int i in numbers)
            {
                if (max < i)
                {
                    max = i;
                }

            }
            Console.WriteLine("Max number: " + max);
        }
        // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
        // For example, with an array [2, 10, 3], your program should write 5 to the console.
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            double average = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            average = sum / numbers.Length;
            Console.WriteLine("Average: " + average);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
