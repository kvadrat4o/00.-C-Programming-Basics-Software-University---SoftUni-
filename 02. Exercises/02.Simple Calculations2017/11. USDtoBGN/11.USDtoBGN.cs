/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 11:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace USDtoBGN
{
	class Program
	{
		public static void Main(string[] args)
		{
			double uSD = double.Parse(Console.ReadLine());
			double bGN = uSD*1.79549;
			Console.WriteLine("{0}",Math.Round(bGN,2));
		}
	}
}