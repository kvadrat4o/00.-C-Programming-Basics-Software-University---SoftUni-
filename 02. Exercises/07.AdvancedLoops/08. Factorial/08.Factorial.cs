/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 20/03/2017
 * Time: 16:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Factorial
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number in range 0 - 12: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine(sum);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}