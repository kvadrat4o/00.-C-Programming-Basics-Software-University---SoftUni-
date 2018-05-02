/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 1/30/2017
 * Time: 2:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace IsPrimeOrNot
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Please enter  your number here. it must be between 1 and 100: ");
			double enteredNum = double.Parse(Console.ReadLine());
			int counter = 0;
			for (int i =1;i<=enteredNum;i++) {
					
					if (enteredNum%i==0) {
					counter++;
				}
			};
			if (counter==2) {
					Console.WriteLine("Your number {0} is prime and divides only to 1 and to itself",enteredNum);
				}
				else {
					Console.WriteLine("Your number {0} is not prime and divides not only to 1 and to itself.",enteredNum);
			};
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}