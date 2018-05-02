/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 23/03/2017
 * Time: 09:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_01HousePainting
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter height of the house: ");
			double x = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter width of side: ");
			double y = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter height of triangle side: ");
			double h = double.Parse(Console.ReadLine());
			
			double siderect,front,back,roofTriangle,roofRect,roof,ground,countRed,countGreen;
			roofTriangle = h*x/2;
			roofRect = x*y;
			roof = 2*roofRect + 2*roofTriangle;
			back = x*x;
			front = x*x - 2.4;
			siderect = x*y - 2.25;
			ground = back+front+2*siderect;
			countGreen = ground/3.4;
			countRed = roof/4.3;
			Console.WriteLine("{0:f2}\n{1:f2}",countGreen,countRed);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}