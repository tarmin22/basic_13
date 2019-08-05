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
        // Print all of the numbers from 0 to 255, 
        // but this time, also print the sum as you go. 
        // For example, your output should be something like this:
        // New number: 0 Sum: 0
        public static void PrintSum()
        {
            int sum = new int();
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine("New number: " + i + "Sum: " + sum);

            }
        }
        // Write a function that would iterate through each item of the given integer array and 
        // print each value to the console. 
        public static void LoopArray(int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine("Number: " + i);

            }

        }
        // Write a function that takes an integer array and prints and returns the maximum value in the array. 
        // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
        // or even a mix of positive numbers, negative numbers and zero.
        public static int FindMax(int[] numbers)
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
            return max;
        }
        // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
        // For example, with an array [2, 10, 3], your program should write 5 to the console.
        public static void GetAverage(int[] numbers)
        {
            double sum = 0;
            double average = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            average = sum / numbers.Length;
            Console.WriteLine("Average: " + average);
        }
        // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
        // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
        public static int[] OddArray()
        {
            int[] ArrOdd = new int[128];
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    ArrOdd[i - 1] = i;
                }
            }
            LoopArray(ArrOdd);

            return ArrOdd;
        }
        // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
        // That are greater than the "y" value. 
        // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
        // (since there are two values in the array that are greater than 3).
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            foreach (int i in numbers)
            {
                if (i == y)
                {
                    count++;
                }
            }
            return count;
        }
        // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
        // For example, [1,5,10,-10] should become [1,25,100,100]
        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= numbers[i];
            }

        }
        // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
        // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }
        // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
        // the minimum value in the array, and the average of the values in the array.
        public static void MinMaxAverage(int[] numbers)
        {
            int max = new int();
            int min = new int();
            double average = 0;
            double sum = 0;
            max = numbers[0];
            min = numbers[0];
            foreach (int i in numbers)
            {
                if (max < i)
                {
                    max = i;
                }
                if (min > i)
                {
                    min = i;
                }

                sum += i;
            }
            average = sum / numbers.Length;
            Console.WriteLine("Max: " + max + "Min: " + min + "Average: " + average);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
