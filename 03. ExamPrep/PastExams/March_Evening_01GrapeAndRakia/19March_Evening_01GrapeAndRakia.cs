/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 23/03/2017
 * Time: 11:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_Evening_01GrapeAndRakia
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter vinegard area: ");
			double area = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter kilos per square meter: ");
			double kilos = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter losses: ");
			double losses = double.Parse(Console.ReadLine());
			double sumKilos,left,rakia,rakiaLeters,grape,saleRakia,saleGrape,totalSale;
			sumKilos = area*kilos;
			left = sumKilos-losses;
			rakia = 0.45*left;
			rakiaLeters = rakia/7.5;
			grape = 0.55*left;
			saleGrape = grape*1.5;
			saleRakia = rakiaLeters*9.8;
			totalSale = saleRakia+saleGrape;
			Console.WriteLine("{0:f2}\n{1:f2}",saleRakia,saleGrape);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}