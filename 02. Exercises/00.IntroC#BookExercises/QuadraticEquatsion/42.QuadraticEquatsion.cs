/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 03/04/2017
 * Time: 10:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace QuadraticEquatsion
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("enter a: ");
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine("enter b: ");
			double b = double.Parse(Console.ReadLine());
			Console.WriteLine("enter c: ");
			double c = double.Parse(Console.ReadLine());
			double d = b*b-4*a*c;
			double x1,x2;
			if (d>0) {
				x1 = (-b+Math.Sqrt(d))/2*a;
				x2 = (-b-Math.Sqrt(d))/2*a;
				Console.WriteLine("{0}\n{1}",x1,x2);
			}
			else if (d==0) {
				x1=x2=(-b/2*a);
				Console.WriteLine("{0}\n{1}",x1,x2);
			}
			else {
				Console.WriteLine("No real roots");
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}