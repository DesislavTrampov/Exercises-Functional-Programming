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

            Action<string[],string> print = (names,title) =>
            {
                foreach(var name in names)
                {
                    Console.WriteLine($"{title} {name}");
                }
            };
            
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            print(input, "Sir");
        }
    }
}
