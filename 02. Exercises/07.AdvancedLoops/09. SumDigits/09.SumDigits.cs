/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 20/03/2017
 * Time: 16:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SumDigits
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number in range 0 - 12: ");
            int num = int.Parse(Console.ReadLine());
            int lastDigit = 0;
            int sum = 0;
            while (num != 0)
            {
                lastDigit = num % 10;
                //Console.WriteLine(lastDigit);
                num /= 10;
                sum += lastDigit;
            }
            Console.WriteLine(sum);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}