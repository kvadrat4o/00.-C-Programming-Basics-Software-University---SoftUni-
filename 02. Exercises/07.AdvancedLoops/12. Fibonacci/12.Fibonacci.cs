/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 21/03/2017
 * Time: 10:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Fibonacci
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int fibNumber = 0;
            int fibNumberTwo = 1;
            int sum = 0;
            if (num > 1)
            {
                for (int i = 1; i <= num + 1; i++)
                {
                    sum = fibNumber + fibNumberTwo;
                    fibNumberTwo = fibNumber;
                    fibNumber = sum;
                }
                Console.WriteLine(sum);
            }
            else if (num <= 1)
            {
                Console.WriteLine("1");
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}