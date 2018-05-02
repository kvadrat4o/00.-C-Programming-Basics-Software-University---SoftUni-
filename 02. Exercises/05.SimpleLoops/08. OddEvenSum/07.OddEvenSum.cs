/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 15:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OddEvenSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double oddSum = 0.0;
            double evenSum = 0.0;
            double diff = 0.00;
            for (double i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes \n Sum = {0}", evenSum);
            }
            else
            {
                diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No \n Diff = {0}", diff);
            }
        }
    }
}

