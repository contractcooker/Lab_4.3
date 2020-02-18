using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4._3_UnitTest
{
    public class PrimeSequence
    {
        private static int count = 10;
        private static int[] sequence = {2,3,5,7,11,13,17,19,23,29 };



        //private static void BuildList()
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (i==0)
        //        {
        //            sequence[i] = 2;
        //        }                
        //    }
        //}
        public static int GetPrime(int v)
        {
            return sequence[v - 1];
        }
    }
}
