/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 17/03/2017
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RectangleOfNStars
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String('*', n));
            }
        }
    }
}