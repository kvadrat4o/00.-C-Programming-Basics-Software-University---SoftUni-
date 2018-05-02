/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/26/2017
 * Time: 8:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VariableTypes
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a = 4825932;
			short b = -44;
			ushort c = 97;
			sbyte d = -115;
			byte e = 112;
			uint f = 200000;
			long g = -1000000000;
			ulong h = 123456789123456789;
			
			Console.WriteLine("Your variables are 'a' = {0}, 'b' = {1}, 'c' = {2}, 'd' = {3}, 'e' = {4}, 'f' = {5}, 'g' = {6}, 'h' = {7}",a,b,c,d,e,f,g,h);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}