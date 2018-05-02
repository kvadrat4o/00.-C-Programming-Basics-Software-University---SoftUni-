/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/26/2017
 * Time: 9:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VariablesSwap
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a = 7;
			int b = 5;
			a=b;
			b=7;
			Console.WriteLine("Variable a is {0} and variable b is {1}. Initially it was reversed situation...",a,b);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}