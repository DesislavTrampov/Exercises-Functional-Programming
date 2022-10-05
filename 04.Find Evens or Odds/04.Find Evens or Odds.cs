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

            
            
            int[] line = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int start = line[0];
            int end = line[1];

            bool isEven = Console.ReadLine() == "even";
            Predicate<int> even = number => number % 2 == 0;
            Predicate<int> odd = number => number % 2 != 0;
            List<int> numbers = new List<int>();
            for(int i = start; i <=end; i++)
            {
                numbers.Add(i);
            }

            if (isEven)
            {
                numbers = numbers.FindAll(even);
            }
            else
            {
                numbers = numbers.FindAll(odd);
            }
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
