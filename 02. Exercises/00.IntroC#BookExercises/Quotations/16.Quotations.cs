/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/26/2017
 * Time: 9:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Quotations
{
	class Program
	{
		public static void Main(string[] args)
		{
			string firstOne = "The \"use\" of quotations causes dificulties";
			string secondOne = "\"The \"use\" of quotations causes dificulties\"";
			Console.WriteLine(firstOne);
			Console.WriteLine(secondOne);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}