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
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Party!") break;
                string[] token = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = token[0];
                string filter = token[1];
                string value = token[2];

                if (action== "Remove")
                {
                    people.RemoveAll(GetPredicate(filter, value));
                }
                else
                {
                    var peopleToDouble = people.FindAll(GetPredicate(filter, value));
                    int index = people.FindIndex(GetPredicate(filter, value));
                    if (index >= 0)
                    {
                        people.InsertRange(index, peopleToDouble);
                    }
                }
            }
            if (people.Any())
            {
                Console.WriteLine($"{String.Join(", ",people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }

        private static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "StartsWith":
                    return x => x.StartsWith(value);
                case "EndsWith":
                    return x => x.EndsWith(value);
                case "Length":
                    return x => x.Length == int.Parse(value);
                default: 
                    return default(Predicate<string>);
            }
        }
    }
}
