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
            Console.WriteLine("Hello!");
            Console.WriteLine();
            Console.WriteLine("Please enter chars:");
            string userInput = Console.ReadLine().ToUpper();
            string result = String.Concat(Alphabet.Where(c => !userInput.Contains(c)));
            Console.WriteLine();
            Console.WriteLine("The result is:");
            Console.WriteLine(result);
            Console.WriteLine($"The number of chars in the result: {result.Length}");
        }
    }
}
