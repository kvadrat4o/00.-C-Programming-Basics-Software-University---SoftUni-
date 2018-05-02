/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 16/03/2017
 * Time: 10:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EqualPairs
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num;

            if (int.TryParse(Console.ReadLine(), out num))
            {
                int previouSum = 0;
                int currSum = 0;
                int maxDiff = 0;
                int diff = 0;
                for (int i = 0; i < num; i++)
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        previouSum = a + b;
                    }
                    else
                    {
                        currSum = a + b;
                        diff = Math.Abs(currSum - previouSum);
                        if (diff > maxDiff)
                        {
                            maxDiff = diff;
                        }
                        previouSum = currSum;
                    }
                }
                if (maxDiff == 0)
                {
                    Console.WriteLine("Yes \n value = {0}", previouSum);
                }
                else
                {
                    Console.WriteLine("No \n maxdiff = {0}", maxDiff);
                }
            }
        }
    }
}