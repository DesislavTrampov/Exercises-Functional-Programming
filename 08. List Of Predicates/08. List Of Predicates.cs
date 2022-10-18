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
            List<Predicate<int>> predicates = new List<Predicate<int>>();

            int endRange = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int[] numbers = Enumerable.Range(1, endRange).ToArray();
            
            foreach (var divider in dividers)

            {
                predicates.Add(x => x % divider == 0);
            }

            foreach(var number in numbers)
            {
                bool isDevesible = true;

                foreach(var match in predicates)
                {
                    if (!match(number))
                    {
                        isDevesible = false;
                        continue;
                    }
                }
                if (isDevesible)
                {
                    Console.Write($"{number} ");
                }
            }


        }
    }
}
