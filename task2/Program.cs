using System;
using System.Collections.Generic;
using System.IO;

namespace task2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string circleLines = File.ReadAllText(args[0]).Replace("\n", "");
            string pointLines = File.ReadAllText(args[1]).Replace("\n", "");

            string[] circleNum = circleLines.Split();
            string[] pointNum = pointLines.Split();

            PositionCalculation(circleNum, pointNum);
        }

        static void PositionCalculation(string[] circleNum, string[] pointNum)
        {
            List<float> circleNumber = new List<float>();
            List<float> pointNumberX = new List<float>();
            List<float> pointNumberY = new List<float>();


            for (int i = 0; i < circleNum.Length; i++)
            {
                float circleNums = float.Parse(circleNum[i]);
                circleNumber.Add(circleNums);
            }

            for (int i = 0; i < pointNum.Length; i++)
            {
                float pointNums = float.Parse(pointNum[i]);
                pointNumberX.Add(pointNums);
            }

            for (int i = 0; i < pointNumberX.Count; i += 2)
                pointNumberY.Add(pointNumberX[i]);

            pointNumberY.ForEach(item => pointNumberX.Remove(item));

            float circleX = circleNumber[0];
            float circleY = circleNumber[1];
            float circleR = circleNumber[2];

            string result = "";

            for (int i = 0; i < pointNumberX.Count; i++)
            {
                double S = Math.Sqrt(Math.Pow((pointNumberX[i] - circleX), 2) + Math.Pow((pointNumberY[i] - circleY), 2));

                if (S == circleR)
                    result += "0\n";

                else if (S < circleR)
                    result += "1\n";

                else
                    result += "2\n";

            }

            Console.WriteLine(result);
        }
    }
}
