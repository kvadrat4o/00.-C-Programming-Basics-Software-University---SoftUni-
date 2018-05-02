/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 05/04/2017
 * Time: 11:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March16_05Fortress
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter a number: ");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", '/',new string('^',n/2),'\\',new string('_',n/2),'/',new string('^',n/2),'\\');
			for (int i = 0; i < n-2; i++) {
				Console.WriteLine("{0}{1}{2}",'|',new string(' ',2*n-2),'|');
			}
			Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", '\\',new string('_',n/2),'/',new string('-',n/2),'\\',new string('_',n/2),'/');
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}