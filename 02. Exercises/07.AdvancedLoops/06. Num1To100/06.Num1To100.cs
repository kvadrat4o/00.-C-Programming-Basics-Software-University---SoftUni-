/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 20/03/2017
 * Time: 12:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Num1To100
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number in range 0 - 100: ");
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
                //Console.Write("Enter a number in the range [1...100]: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", num);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}


