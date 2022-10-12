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
            int lengthWord = int.Parse(Console.ReadLine());
            List<string> line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<List<string>,Predicate<string>> PrintLine = (line, lengthWord) =>
            {
                foreach (string word in line)
                {
                    if (lengthWord(word))
                    {
                        Console.WriteLine(word);
                    }
                }
            };
            PrintLine(line, x => x.Length <= lengthWord);
        }
    }
}
