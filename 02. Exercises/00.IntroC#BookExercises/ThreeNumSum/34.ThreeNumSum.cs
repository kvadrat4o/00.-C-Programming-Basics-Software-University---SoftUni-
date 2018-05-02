/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 24/03/2017
 * Time: 14:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ThreeNumSum
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter a num: ");
			int a  = int.Parse(Console.ReadLine());
			Console.WriteLine("enter a num: ");
			int b  = int.Parse(Console.ReadLine());
			Console.WriteLine("enter a num: ");
			int c  = int.Parse(Console.ReadLine());
			int sum = a+b+c;
			Console.WriteLine("{0}",sum);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}