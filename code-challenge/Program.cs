using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace code_challenge
{
    class Program
    {
        const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const int ReadBufferSize = 256;

        static void Main(string[] args)
        {
            bool verified = false;
            string userInput = "";

            // 1. Get user input
            Console.WriteLine("Hello!");
            while (!verified)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter chars:");
                userInput = Console.ReadLine().ToUpper();

                if(userInput.Length <= ReadBufferSize)
                {
                    verified = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Input is limited to 256 chars.");
                }
            }

            // 2. Print out alphabet minus any chars from the user input
            //    and count of chars left in alphabet
            string result = String.Concat(Alphabet.Where(c => !userInput.Contains(c)));
            Console.WriteLine();
            Console.WriteLine("The result is:");
            Console.WriteLine(result);
            Console.WriteLine($"The number of chars in the result: {result.Length}");
        }
    }
}
