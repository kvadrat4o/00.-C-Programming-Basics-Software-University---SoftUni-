/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/25/2017
 * Time: 2:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AgeIn10Years
{
	class Program
	{
		public static void Main(string[] args)
		{
			int yourAge = int.Parse(Console.ReadLine());
			Console.WriteLine("Your age in 10 years will be {0}",yourAge + 10);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}