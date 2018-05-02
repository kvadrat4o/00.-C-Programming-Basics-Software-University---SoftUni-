/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/26/2017
 * Time: 9:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace StringToObject
{
	class Program
	{
		public static void Main(string[] args)
		{
			string one = "Hello";
			string two = "World!";
			object concatenatedStrings = one+" "+two;
			Console.WriteLine(concatenatedStrings);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}