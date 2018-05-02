/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 17/03/2017
 * Time: 17:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ChristmasTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            //left half
            //Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + 1; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write(new string('*', i));
                Console.Write(" | ");
                Console.WriteLine(new string('*', i));
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}