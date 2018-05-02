/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 27/02/2017
 * Time: 17:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SleepyCat
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter the free days you have this year: ");
			int days = int.Parse(Console.ReadLine());
			int restMinutes = 127*days;
			int workMinutes = 63*(365-days);
			int sumMinutes = restMinutes+workMinutes;
			int difference ;
			int H,M;
			if (30000>sumMinutes) {
				difference = 30000-sumMinutes;
				H = difference/60;
				M = (difference-H*60);
				Console.WriteLine("Tom will run away");
				Console.WriteLine("{0} hours and {1} minutes less for play",H,M);
			}
			else {
				difference = sumMinutes-30000;
				H = difference/60;
				M = (difference-H*60);
				Console.WriteLine("Tom sleeps well");
				Console.WriteLine("{0} hours and {1} minutes more for play",H,M);
			};
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}