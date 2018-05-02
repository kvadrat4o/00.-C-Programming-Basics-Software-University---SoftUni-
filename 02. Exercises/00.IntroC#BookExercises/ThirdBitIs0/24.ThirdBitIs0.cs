/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/27/2017
 * Time: 10:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ThirdBitIs0
{
	class Program
	{
		public static void Main(string[] args)
		{
			char [] arrOne;
			Console.WriteLine("Please entewr  your number here: ");
			int enteredNum = int.Parse(Console.ReadLine());
			string firstString = enteredNum.ToString();
			arrOne = firstString.ToCharArray(0,firstString.Length);
			if (arrOne[(firstString.Length-3)]==7) {
				Console.WriteLine("The third number from right to left of your number {0} is {1}Yeah!!!", enteredNum,(firstString.Length-3));
			}
			else {
				Console.WriteLine("The third number from right to left of your number {0} is {1}. Oops!!!", enteredNum,(firstString.Length-3));
			};
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}