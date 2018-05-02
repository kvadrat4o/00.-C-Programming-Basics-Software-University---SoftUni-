/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 10:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TrapezoidArea
{
	class Program
	{
		public static void Main(string[] args)
		{
			double b1 = double.Parse(Console.ReadLine());
			double b2 = double.Parse(Console.ReadLine());
			double h = double.Parse(Console.ReadLine());
			double area = ((b1+b2)/2)*h;
			Console.WriteLine("Thrapeziod area: {0} ",area);
		}
	}
}