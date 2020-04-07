﻿using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1: Random Array
            // int[] RandomArrayTest = RandomArray();

            // #2: Coin Flip
            string TossCoinTest = TossCoin();
        }

        public static int[] RandomArray()
        // Place 10 random ints between 5~25. Print min, max, sum of all vals
        {
            int[] answer = new int[10];
            int min = 25;
            int max = 5;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Random rand = new Random();
                int newNum = rand.Next(5,25);
                answer[i] = newNum;     
                if (min > newNum) min = newNum;
                if (max < newNum) max = newNum;
                sum += newNum;
            }
            Console.WriteLine($"min:{min}, max:{max}, sum:{sum}");
            return answer;
        }

        public static string TossCoin()
        {
            
            return "";
        }
    }
}
