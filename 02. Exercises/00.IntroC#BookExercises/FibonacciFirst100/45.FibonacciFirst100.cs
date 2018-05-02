/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 03/04/2017
 * Time: 11:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FibonacciFirst100
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			int n = 0;
			int a = 1;
			int sum = 0;
			for (int i = 0; i <=100; i++) {
				sum = a+n;
				Console.WriteLine(sum);
				a = n;
				n = sum;
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}