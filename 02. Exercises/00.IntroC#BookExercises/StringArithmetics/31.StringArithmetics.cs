/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 1/30/2017
 * Time: 3:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace StringArithmetics
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a four digit number here: ");
			int enterNum = int.Parse(Console.ReadLine());
			int first = enterNum/10;
			int second = (enterNum/10)/10;
			int third  = ((enterNum/10)/10)/10;
			int fourth  = (((enterNum/10)/10)/10)/10;
			Console.Write("First is {0}, second is {1}, third is {2} and fourth is {3}",first,second,third,fourth);
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
