/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 24/03/2017
 * Time: 15:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MaxValue
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter number: ");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("enter number: ");
			int b = int.Parse(Console.ReadLine());
			// TODO: Implement Functionality Here
			Console.WriteLine("{0}", Math.Max(a,b));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}