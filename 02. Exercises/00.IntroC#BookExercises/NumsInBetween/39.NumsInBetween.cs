/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 03/04/2017
 * Time: 09:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NumsInBetween
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("start num");
			int a = int.Parse(Console.ReadLine());
			//Console.WriteLine("end num");
			int b = int.Parse(Console.ReadLine());
			int counter = 0;
			for (int i = a; i <= b; i++) {
				if (i%5==0) {
					counter++;
				}
			}
			Console.WriteLine("{0}",counter);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}