/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/26/2017
 * Time: 9:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FloatDoubleDecimal
{
	class Program
	{
		public static void Main(string[] args)
		{
			float a = 12.345F;
			double b = 8923.12345897D;
			double  c = 34.123456789D;
			decimal d = 3456.123456789123456789123456789M;
			Console.WriteLine("Your variables are 'a' = {0} - float, 'b' = {1} - double, 'c' = {2} - double, 'd' = {3} - decimal",a,b,c,d);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}