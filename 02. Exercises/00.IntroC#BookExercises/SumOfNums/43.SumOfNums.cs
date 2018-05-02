/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 03/04/2017
 * Time: 11:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SumOfNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter a num: ");
			int num = int.Parse(Console.ReadLine());
			int sum = 0;
			for (int i = 0; i < num; i++) {
				int n = int.Parse(Console.ReadLine());
				sum+=n;
			}
			Console.WriteLine(sum);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}