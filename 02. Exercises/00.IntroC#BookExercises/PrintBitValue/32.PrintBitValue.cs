/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 24/03/2017
 * Time: 14:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PrintBitValue
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter a number: ");
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine("enter a position: ");
			int p = int.Parse(Console.ReadLine());
			int i = 1;
			int mask = i<<p;
			Console.WriteLine((num&mask) != 0 ? 1 : 0 );
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}