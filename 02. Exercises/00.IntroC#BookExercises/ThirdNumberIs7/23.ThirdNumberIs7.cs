/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/27/2017
 * Time: 10:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ThirdNumberIs7
{
	class Program
	{
		public static void Main(string[] args)
		{
			char [] arrOne;
			Console.WriteLine("Please entewr  your number here: ");
			int enteredNum = int.Parse(Console.ReadLine());
			if ((enteredNum/100)%10==7) {
				Console.WriteLine("The third number from right to left of your number {0} is {1}...Yeah!!!", enteredNum,((enteredNum/100)%10));
			}
			else {
				Console.WriteLine("The third number from right to left of your number {0} is {1}...Oops!!!", enteredNum,((enteredNum/100)%10));
			};
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}