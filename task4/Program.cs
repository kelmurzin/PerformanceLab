using System;
using System.Collections.Generic;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            StreamReader file = new StreamReader(args[0]);
            string line;

            List<int> number = new List<int>();
            

            while ((line = file.ReadLine()) != null)
            {
                int num = int.Parse(line);
                number.Add(num);
            }
            
            int[] array = new int[number.Count];
            number.CopyTo(array);
            FindMinMoves(array);

        }

        static void FindMinMoves(int[] arrayNum)
        {
            int[] nums = arrayNum;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];

            int average = sum / nums.Length;
            int numberMoves = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= average)
                    numberMoves += average - nums[i];
                else
                    numberMoves += nums[i] - average;
            }

            Console.WriteLine(numberMoves);
        }

    }
}

