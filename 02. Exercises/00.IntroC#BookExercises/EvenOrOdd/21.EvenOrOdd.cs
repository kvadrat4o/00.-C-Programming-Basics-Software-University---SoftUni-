/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/27/2017
 * Time: 10:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EvenOrOdd
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number here:");
			int enteredNum = int.Parse(Console.ReadLine());
			if (enteredNum%2==0) {
				Console.WriteLine("Your number is even....");
			}
			else {
				Console.WriteLine("Your number is odd....");
			};
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}