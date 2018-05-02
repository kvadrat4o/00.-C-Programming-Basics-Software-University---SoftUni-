/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 17/03/2017
 * Time: 17:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace House
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter number beteen 2 and 100 here:");
            int n = int.Parse(Console.ReadLine());
            int countingStars = 2;
            if (n % 2 != 0)
            {

                //first row
                Console.WriteLine("{0}{1}{2}", new string('-', n / 2), new string('*', 1), new string('-', n / 2));
                countingStars++;
            }
            //second part
            for (int k = 0; k < n / 2; k++)
            {
                Console.WriteLine("{0}{1}{2}", new string('-', n / 2 - 1 - k), new string('*', countingStars + 2 * k), new string('-', n / 2 - 1 - k));
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{2}", new string('|', 1), new string('*', n - 2), new string('|', 1));
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}