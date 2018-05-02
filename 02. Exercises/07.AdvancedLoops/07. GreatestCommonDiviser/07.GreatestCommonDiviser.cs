/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 20/03/2017
 * Time: 15:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GreatestCommonDiviser
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter wto numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
                if (a == 0)
                {
                    Console.WriteLine(b);
                }
                else if (b == 0)
                {
                    Console.WriteLine(a);
                }
            }


            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
//