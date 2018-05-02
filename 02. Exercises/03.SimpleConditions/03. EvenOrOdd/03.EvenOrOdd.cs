/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 09:41
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
			double enteredNumber = double.Parse(Console.ReadLine());
			if (enteredNumber % 2 == 0)
            {
				Console.WriteLine("even");
			}
			else
            {
				Console.WriteLine("odd");
			}
			
		}
	}
}