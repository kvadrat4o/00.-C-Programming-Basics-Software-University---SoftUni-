/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 03/04/2017
 * Time: 10:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;

namespace MacFive
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter a num");
			int [] arr1 = new int[5];
			for (int  i=0;  i< 5; i++) {
				arr1[i] = int.Parse(Console.ReadLine());
			}
			int c = arr1.Max();
			Console.WriteLine(c);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}