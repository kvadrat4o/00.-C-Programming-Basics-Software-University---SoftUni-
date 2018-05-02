/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 1/30/2017
 * Time: 12:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RectangeProperties
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter rectangle's width 'a': ");
			float a = float.Parse(Console.ReadLine());
			Console.WriteLine("Please enter rectangle's height 'b': ");
			float b = float.Parse(Console.ReadLine());
			float perimeter = (2*a+2*b);
			float area = (a*b);
			Console.WriteLine("The rectangle with width 'a' = {0} and height 'b' = {1} has perimeter {2} and area {3}.",a,b,perimeter,area);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}