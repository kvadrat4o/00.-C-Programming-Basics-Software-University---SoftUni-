/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 1/30/2017
 * Time: 12:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ThrapecoidSurface
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter the 'a' parameter: ");
			float a = float.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the 'b' parameter: ");
			float b = float.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the 'h' parameter: ");
			float h = float.Parse(Console.ReadLine());
			float surface = ((a+b)/2*h);
			
			Console.WriteLine("The Surface of thrapecoid with 'a' = {0}, 'b' = {1} and 'h' = {2} is : {3}", a,b,h,surface);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}