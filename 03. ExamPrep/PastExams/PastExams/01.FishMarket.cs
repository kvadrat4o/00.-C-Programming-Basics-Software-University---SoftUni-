/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 27/02/2017
 * Time: 12:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PastExams
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter the price for your products below:");
			Console.WriteLine("Price for 1kg skumria is: ");
			double skumria = double.Parse(Console.ReadLine());
			Console.WriteLine("Price for 1kg caca is: ");
			double caca = double.Parse(Console.ReadLine());
			Console.WriteLine("How many kgs palamud do you need: ");
			double palamud = double.Parse(Console.ReadLine());
			Console.WriteLine("How many kgs safrid do you need: ");
			double safrid = double.Parse(Console.ReadLine());
			Console.WriteLine("How many kgs clams do you need: ");
			double clams = double.Parse(Console.ReadLine());
			
			double palamudkg = palamud*(skumria+(0.60*skumria));
			double safridkg = safrid*(caca+(0.80*caca));
			double clamkg = clams*7.50;
			double sum = Math.Round(palamudkg+safridkg+clamkg,2);
			Console.WriteLine("The total amount needed for this products is: {0}",sum);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}