/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/27/2017
 * Time: 10:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BoolDivision
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			bool dividedByTwo = false;
			Console.WriteLine("Please enter  your number here: ");
			int enteredNum = int.Parse(Console.ReadLine());
			if (enteredNum%5==0) {
				if(enteredNum%7==0) {
					dividedByTwo=true;
					Console.WriteLine("Your number is devided by 5, and by 7, and the value ouf our boolean variable is {0}",dividedByTwo);
				}
				else {
					Console.WriteLine("Your number is devided by 5, but not by 7, and the value ouf our boolean variable is {0}",dividedByTwo);
				}
			}
			else if (enteredNum%7==0) {
				Console.WriteLine("Your number is devided by 7, but not by 5, and the value ouf our boolean variable is {0}",dividedByTwo);
			}
			else {
				Console.WriteLine("Your number is nor devided by 5, or by 7, and the value ouf our boolean variable is {0}",dividedByTwo);
			};
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}