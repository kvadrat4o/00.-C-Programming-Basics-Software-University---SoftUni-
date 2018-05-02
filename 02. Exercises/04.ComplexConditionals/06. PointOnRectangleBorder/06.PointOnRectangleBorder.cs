/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 09:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PointOnRectangleBorder
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Please enter first point's x: ");
			double x1 = double.Parse(Console.ReadLine());
			//Console.WriteLine("Please enter first point's y: ");
			double y1 = double.Parse(Console.ReadLine());
			//Console.WriteLine("Please enter second point's x: ");
			double x2 = double.Parse(Console.ReadLine());
			//Console.WriteLine("Please enter second point's y: ");
			double y2 = double.Parse(Console.ReadLine());
			//Console.WriteLine("Please enter x: ");
			double x = double.Parse(Console.ReadLine());
			//Console.WriteLine("Please enter y: ");
			double y = double.Parse(Console.ReadLine());
			if (((x==x1)||(x==x2))&&((y>=y1)&&(y<=y2)))
            {
				Console.WriteLine("Border");
			}
			else if (((y==y1)||(y==y2))&&((x>=x1)&&(x<=x2)))
            {
				Console.WriteLine("Border");
			}
			else
            {
				Console.WriteLine("Inside / Outside");
			}
		}
	}
}