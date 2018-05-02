/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 10:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TradeComission
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter city: ");
			string city = Console.ReadLine().ToLower();
			Console.WriteLine("Enter volume sales: ");
			double s = double.Parse(Console.ReadLine());
			double comission = -1.00;
			if (city=="sofia")
            {
				if ((s>=0)&&(s<=500))
                {
					comission = s*0.050;
					Console.WriteLine(Math.Round(comission,2));
				}
				else if ((s>500)&&(s<=1000))
                {
					comission = s*0.070;
					Console.WriteLine(Math.Round(comission,2));
				}
				else if ((s>1000)&&(s<=10000))
                {
					comission = s*0.080;
					Console.WriteLine(Math.Round(comission,2));
				}
				else if (s>10000)
                {
					comission = s*0.120;
					Console.WriteLine(Math.Round(comission,2));
				}
				else
                {
					Console.WriteLine("error");
				}
			}
			else if (city=="plovdiv")
            {
				if ((s>=0)&&(s<=500))
                {
					comission = s*0.055;
					Console.WriteLine(Math.Round(comission,2));
				}
				else if ((s>500)&&(s<=1000))
                {
					comission = s*0.080;
					Console.WriteLine(Math.Round(comission,2));
				}
				else if ((s>1000)&&(s<=10000))
                {
					comission = s*0.120;
					Console.WriteLine(Math.Round(comission,2));
				}
				else if (s>10000)
                {
					comission = s*0.145;
					Console.WriteLine(Math.Round(comission,2));
				}
				else
                {
					Console.WriteLine("error");
				}
			}
			else if (city=="varna")
            {
				if ((s>=0)&&(s<=500))
                {
					comission = s*0.045;
					Console.WriteLine(Math.Round(comission,2));
				}
				else if ((s>500)&&(s<=1000))
                {
					comission = s*0.075;
					Console.WriteLine(Math.Round(comission,2));
				}
				else if ((s>1000)&&(s<=10000))
                {
					comission = s*0.100;
					Console.WriteLine(Math.Round(comission,2));
				}
				else if (s>10000)
                {
					comission = s*0.130;
					Console.WriteLine(Math.Round(comission,2));
				}
				else
                {
					Console.WriteLine("error");
				}
			}
			else
            {
				Console.WriteLine("error");
			}
		}
	}
}