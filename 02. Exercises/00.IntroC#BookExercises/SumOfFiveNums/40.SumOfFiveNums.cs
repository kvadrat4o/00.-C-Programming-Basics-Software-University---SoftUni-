/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 03/04/2017
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SumOfFiveNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			int c =0;
			int sum = 0;
			for (int i = 1; i <=5; i++) {
				if (int.TryParse(Console.ReadLine(),out c)) {
					sum+=c;
				}
				else {
					Console.WriteLine();
					int.TryParse((Console.ReadLine()),out c);
				}
			}
			Console.WriteLine("{0}",sum);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}