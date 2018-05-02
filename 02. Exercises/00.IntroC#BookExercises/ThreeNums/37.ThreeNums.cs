/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 03/04/2017
 * Time: 09:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ThreeNums
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("first num");
			int a = int.Parse(Console.ReadLine());
			//Console.WriteLine("second num");
			double b = double.Parse(Console.ReadLine());
			//Console.WriteLine("third num");
			double c = double.Parse(Console.ReadLine());
			
			Console.WriteLine("{0,-10:X}\n{1,-10:f2}\n{2,-10:f2}",a,b,c);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}