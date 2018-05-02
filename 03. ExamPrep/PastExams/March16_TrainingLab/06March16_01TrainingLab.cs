/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 04/04/2017
 * Time: 10:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March16_TrainingLab
{
	class Program
	{
		public static void Main(string[] args)
		{
			double width = double.Parse(Console.ReadLine()) * 100;
        	double height = double.Parse(Console.ReadLine()) * 100;

	        double cols = Math.Truncate((height - 100) / 70);
	        double rows = Math.Truncate(width / 120);
	        double seats = rows * cols - 3;
	        Console.WriteLine(seats);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}