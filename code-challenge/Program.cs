using System;
using System.Collections.Generic;
using System.Linq;

namespace code_challenge
{
    class Program
    {
        const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        static void Main(string[] args)
        {
            Dictionary<char, bool> d = new Dictionary<char, bool>();

            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine("Please enter chars:");
            string userInput = Console.ReadLine().ToUpper();

            string result = String.Concat(Alphabet.Where(c => !userInput.Contains(c)));

            Console.WriteLine();
            Console.WriteLine("The result is:");
            Console.WriteLine(result);
        }
    }
}
