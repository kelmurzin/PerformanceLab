using System;
using System.IO;
using System.Linq;

namespace task1
{
    class Program
    {

        public static void Main(string[] args)

        {
            string number = File.ReadAllText(args[0]).Replace("\n", "");
            string[] arrayNumber = number.Split();
            
            int n = int.Parse(arrayNumber[0]);
            int m = int.Parse(arrayNumber[1]);

            FindWay(n, m);

        }

        static void FindWay(int n, int m)
        {
            int[] array = Enumerable.Range(1, n).ToArray();

            int arrayIndex = array[0];
            int variable;
            m -= 1;
            Console.WriteLine(arrayIndex);

            do
            {
                variable = arrayIndex + m;
                if (variable <= n)
                    arrayIndex = variable;

                else
                {
                    arrayIndex = variable % n;
                    if (arrayIndex == 0)
                        arrayIndex = n;
                }

                if (arrayIndex != 1)
                    Console.WriteLine(arrayIndex);

            } while (arrayIndex != 1);
        }
    }
}


