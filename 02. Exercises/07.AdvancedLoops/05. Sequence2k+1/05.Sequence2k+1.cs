/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 20/03/2017
 * Time: 10:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Sequence2k_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            while (num <= n)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;

            }
        }
    }
}