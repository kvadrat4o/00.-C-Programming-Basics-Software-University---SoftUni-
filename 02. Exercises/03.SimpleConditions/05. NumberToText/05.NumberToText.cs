/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 09:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NumkberToText
{
	class Program
	{
		public static void Main(string[] args)
		{
			int enteredNum = int.Parse(Console.ReadLine());
			if (enteredNum<=9)
            {
				switch (enteredNum)
	            {
	                case 1:
	                    Console.WriteLine("one");
	                    break;
	                case 2:
	                    Console.WriteLine("two");
	                    break;
	                case 3:
	                    Console.WriteLine("three");
	                    break;
	                case 4:
	                    Console.WriteLine("four");
	                    break;
	            	case 5:
	                    Console.WriteLine("five");
	                    break;
	                case 6:
	                    Console.WriteLine("six");
	                    break;
	                case 7:
	                    Console.WriteLine("seven");
	                    break;
	                case 8:
	                    Console.WriteLine("eight");
	                    break;
	                case 9:
	                    Console.WriteLine("nine");
	                    break;
	                default:
	                    Console.WriteLine("Default case");
	                    break;
	            }
			}
			else
            {
				Console.WriteLine("number too big");
			}
		}
	}
}