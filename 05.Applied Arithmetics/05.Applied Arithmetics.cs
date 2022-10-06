using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace exsercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<int[], int[]> add = numbers =>
            {
                for(int i= 0; i< numbers.Length; i++)
                {
                    numbers[i]++;
                }
                return numbers;

            };
            Func<int[], int[]> multiply = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i]*=2;
                }
                return numbers;

            };
            Func<int[], int[]> subtract = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i]--;
                }
                return numbers;

            };
            Action<int[]> print = numbers => Console.WriteLine(String.Join(" ",numbers));

            int[] line = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end") break;

                switch (input)
                {
                    case "add":
                       line = add(line);
                        break;
                    case "multiply":
                        line =multiply(line);
                        break;
                    case "subtract":
                      line =  subtract(line);
                        break;

                    case "print":
                        print(line);
                        break;

                }

            }
            
        }
    }
}
