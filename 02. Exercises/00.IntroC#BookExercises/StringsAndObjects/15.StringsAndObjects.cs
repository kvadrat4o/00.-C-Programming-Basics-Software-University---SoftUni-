/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/26/2017
 * Time: 9:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace StringsAndObjects
{
	class Program
	{
		public static void Main(string[] args)
		{
			string one = "Hello";
			string two = "World!";
			object concatenatedStrings = one+" "+two;
			string lastString = concatenatedStrings.ToString();
			Console.WriteLine(lastString);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}