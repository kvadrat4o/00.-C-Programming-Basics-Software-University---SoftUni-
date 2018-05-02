/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 17/03/2017
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SquareFrame
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            char used = '|';

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    used = '+';
                }
                Console.Write(used + " ");
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine(used);
                used = '|';
            }
        }
    }
}