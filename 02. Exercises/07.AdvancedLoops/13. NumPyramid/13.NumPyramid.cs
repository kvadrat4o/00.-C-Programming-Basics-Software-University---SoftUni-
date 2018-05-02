/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 21/03/2017
 * Time: 10:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NumPyramid
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int a = 1;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(a + " ");
                    a++;
                    if (a > num)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (a > num)
                {
                    break;
                }
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}