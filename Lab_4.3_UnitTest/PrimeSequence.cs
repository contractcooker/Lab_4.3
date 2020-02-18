using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab_4._3_UnitTest
{
    public class PrimeSequence
    {
        private static int count = 100;
        //private static int[] sequence = {2,3,5,7,11,13,17,19,23,29 };
        private static ArrayList primes = new ArrayList();

        public static int Count { get => count; }

        private static void BuildList()
        {
            for (int i = 2; primes.Count < Count; i++)
            {
                bool divisible = false;
                foreach (int num in primes)
                {
                    if (i % num == 0)
                    {
                        divisible = true;
                        break;
                    }
                }
                if (divisible == false)
                {
                    primes.Add(i);
                }
            }
        }
        public static int GetPrime(int v)
        {
            BuildList();
            return (int)primes[v - 1];
        }
    }
}
