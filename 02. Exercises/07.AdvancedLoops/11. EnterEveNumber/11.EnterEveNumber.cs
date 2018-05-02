/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 21/03/2017
 * Time: 09:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EnterEveNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number: ");
            int num = 0;
            while (true)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 != 0)
                    {
                        Console.WriteLine("The number is not even.");
                    }
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine("Even number entered: {0}", num);
        }
    }
}