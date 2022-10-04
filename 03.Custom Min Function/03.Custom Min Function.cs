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

            
            
            int[] numbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();


            Func<int[], int> num = numbers => numbers.Min(num => num);

            Console.WriteLine(num(numbers));

        }
    }
}
