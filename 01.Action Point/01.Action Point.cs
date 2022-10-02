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

            Action<string[]> print = (strings) => Console.WriteLine(string.Join(Environment.NewLine,strings));
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            print(input);
        }
    }
}
