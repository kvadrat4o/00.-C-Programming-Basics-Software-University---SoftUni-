/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 17/03/2017
 * Time: 17:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Sunglasses
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            //first ;ine
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
            //middle part
            char used = ' ';
            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 1) / 2 - 1)
                {
                    used = '|';
                }
                Console.Write('*' + new string('/', (2 * n) - 2) + '*');
                Console.Write(new string(used, n));
                Console.WriteLine('*' + new string('/', (2 * n) - 2) + '*');
                used = ' ';
            }
            //last line
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
        }
    }
}