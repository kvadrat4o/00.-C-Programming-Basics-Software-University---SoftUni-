/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 20/03/2017
 * Time: 16:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace IsPrime
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool prime = false;
            if (num < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 1; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        prime = false;
                        //Console.WriteLine("Prime");
                    }
                }
                if (prime == true)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not Prime");
                }
            }
            // TODO: Implement Functionality Here

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}



