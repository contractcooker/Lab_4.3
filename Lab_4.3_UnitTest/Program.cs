using System;

namespace Lab_4._3_UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Percolator");

            while (true)
            {
                Console.WriteLine("Which prime number are you looking for? Please enter a number from 1-10: ");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine($"The number {input} prime is {PrimeSequence.GetPrime(input)}"); 
            }
        }
    }
}
