/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 27/02/2017
 * Time: 13:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RemontNaPlochki
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter the width of the area: ");
			double N = Double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the width of the tile: ");
			double W = Double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the length of the tile: ");
			double L = Double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the width of the bench: ");
			double M = Double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the length of the bench: ");
			double O = Double.Parse(Console.ReadLine());
			
			double bench = M*O;
			double area = N*N;
			double tileArea = W*L;
			double count = (area-bench)/tileArea;
			double time = count*0.2;
			Console.WriteLine("For area of {0} square meters are needed {1} tiles, placed for {2} minutes. ",area,count,time);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}