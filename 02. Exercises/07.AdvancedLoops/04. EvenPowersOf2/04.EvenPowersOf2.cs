/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 20/03/2017
 * Time: 10:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EvenPowersOf2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            if (n == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine(num);
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(num * 4);
                        num *= 4;
                    }
                }
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}