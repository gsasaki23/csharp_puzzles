using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1: Random Array");
            int[] RandomArrayTest = RandomArray();

            Console.WriteLine("\n#2: Coin Flip");
            string TossCoinTest = TossCoin();
            double TossMultipleCoinsTest = TossMultipleCoins(5);
            Console.WriteLine("Chance of flipping Head: " + TossMultipleCoinsTest);

            Console.WriteLine("\n#3: Names");
            string[] NamesTest = Names();
            Console.WriteLine("\nAnswer:");
            foreach (string name in NamesTest) Console.WriteLine(name);
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
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            if (rand.Next(0,2) == 0) 
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else
            {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }
        public static double TossMultipleCoins(int num)
        {
            if (num <= 0) return 0;

            int headCount = 0;
            int tailCount = 0;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Tossing a Coin!");
                Random rand = new Random();
                if (rand.Next(0,2) == 0) 
                {
                    Console.WriteLine("Heads");
                    headCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                }
            }
            return (double) headCount / (headCount + tailCount);
        }
    
        public static string[] Names()
        {
            // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            string [] start = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            
            // Shuffle the list and print the values in the new order
            // ***Approach: swap 2 random non-matching indexes 5 times.
            string temp;
            for (int i = 0; i < 5; i++)
            {
                Random rand = new Random();
                int a = rand.Next(0,start.Length);
                int b = rand.Next(0,start.Length);
                
                // Runs forever until 2 random non-matching indexes are found
                bool match = true;
                while (match)
                {
                    if (a != b) match = false;
                    a = rand.Next(0,start.Length);
                    b = rand.Next(0,start.Length);
                }
                
                // Swap a and b
                temp = start[a];
                start[a] = start[b];
                start[b] = temp;
            }
            Console.WriteLine("After the shuffle and before the filter, the names are: ");
            foreach (string name in start) Console.WriteLine(name);

            // Return a list that only includes names longer than 5 characters
            string[] answer = Array.FindAll(start, x => x.Length > 5);
            return answer;
        }
    }
}
