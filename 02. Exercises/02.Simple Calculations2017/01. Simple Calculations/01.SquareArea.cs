/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 09:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Simple_Calculations
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("a = ");
			decimal a = decimal.Parse(Console.ReadLine());
			Console.WriteLine("Square: {0}",a*a);
		}
	}
}