/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 17/03/2017
 * Time: 16:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RhombusOfStars
{
    class Program
    {
        public static void Main(string[] args)
        {
            //first half


            //Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - 1 - i));
                Console.Write('*');
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();

            }
            //second half
            for (int j = 0; j < n - 1; j++)
            {
                Console.Write(new string(' ', j + 1));
                Console.Write('*');
                for (int i = 0; i < n - 2 - j; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}