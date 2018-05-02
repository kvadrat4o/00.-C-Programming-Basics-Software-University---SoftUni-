/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/25/2017
 * Time: 2:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace First100
{
	class Program
	{
		public static void Main(string[] args)
		{
			for (int i = 2;i<=100;i++) {
				if (i%2==0) {
					Console.WriteLine(i);
				}
				else {
					Console.WriteLine(-i);
				}
			};
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}