/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 14:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace IfEqualNumbers
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter first number: ");
			double a = double.Parse(Console.ReadLine());
			//Console.WriteLine("Enter second number: ");
			double b = double.Parse(Console.ReadLine());
			//Console.WriteLine("Enter third number: ");
			double c = double.Parse(Console.ReadLine());
			if ((a==b)&&(b==c)&&(a==c)) {
				Console.WriteLine("yes");
			}
			else {
				Console.WriteLine("no");
			}
		}
	}
}