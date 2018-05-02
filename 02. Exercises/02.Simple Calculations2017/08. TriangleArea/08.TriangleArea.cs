/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 11:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TriangleArea
{
	class Program
	{
		public static void Main(string[] args)
		{
			double a = double.Parse(Console.ReadLine());
			double h = double.Parse(Console.ReadLine());
			double area = Math.Round(((a*h)/2),2);
			Console.WriteLine("Triangle area = {0}",area);
		}
	}
}