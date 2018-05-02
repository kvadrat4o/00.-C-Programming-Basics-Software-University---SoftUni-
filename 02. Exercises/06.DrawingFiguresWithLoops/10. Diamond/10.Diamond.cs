/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 17/03/2017
 * Time: 18:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Diamond
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number here: ");
            int n = int.Parse(Console.ReadLine());
            int countDashes = 0;
            if (n % 2 == 1)
            {
                //first line
                Console.WriteLine("{0}{1}{2}", new string('-', n / 2), "*", new string('-', n / 2));
                countDashes++;
            }
            //middle part
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}" + "*" + "{1}" + "*" + "{2}", new string('-', n / 2 - 1 - i), new string('-', countDashes + 2 * i), new string('-', n / 2 - 1 - i));
            }
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}" + "*" + "{1}" + "*" + "{2}", new string('-', 1 + i), new string('-', n - 4 - 2 * i), new string('-', 1 + i));
            }
            if (n % 2 == 1)
            {
                //last line
                Console.WriteLine("{0}{1}{2}", new string('-', n / 2), "*", new string('-', n / 2));
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}