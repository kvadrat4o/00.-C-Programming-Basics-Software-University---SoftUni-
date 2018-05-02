/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 21/03/2017
 * Time: 11:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NumTable
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    int n = row + col + 1;
                    if (n > num)
                    {
                        n = 2 * num - n;
                    }
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}