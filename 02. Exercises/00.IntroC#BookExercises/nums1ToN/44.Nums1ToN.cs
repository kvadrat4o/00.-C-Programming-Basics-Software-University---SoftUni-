/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 03/04/2017
 * Time: 11:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace nums1ToN
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("enter a num: ");
			int num = int.Parse(Console.ReadLine());
			for (int i = 1; i <=num; i++) {
				Console.WriteLine("{0}\n",i);
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}