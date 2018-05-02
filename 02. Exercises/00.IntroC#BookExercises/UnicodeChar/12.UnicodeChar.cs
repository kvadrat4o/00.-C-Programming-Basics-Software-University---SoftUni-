/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/26/2017
 * Time: 9:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace UnicodeChar
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int code = 72;
	        Console.WriteLine("The hexadecimal representation of code 72 is: {0:X}", code);
	        char symbol = '\u0048';
	        Console.WriteLine("The symbol is: {0}", symbol);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}