/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 21/03/2017
 * Time: 12:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_01DogHouse
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter side length: ");
			double side = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter side height: ");
			double height = double.Parse(Console.ReadLine());
			double countGreen = 0.00;
			double countRed = 0.00;
			double sides,backSquare,backTriangle,entrance,roof,back,front,squaresGreen,squaresRed;
			sides = 2*(side*side/2);
			backSquare = (side/2)*(side/2);
			backTriangle = ((side/2)*(height-side/2))/2;
			entrance = (side/5)*(side/5);
			roof = 2*(side*side/2);
			back = backSquare+backTriangle;
			front = backSquare+backTriangle-entrance;
			squaresGreen = sides+front+back;
			squaresRed = roof;
			countGreen = Math.Round((squaresGreen/3),2);
			countRed = Math.Round((squaresRed/5),2);
			// TODO: Implement Functionality Here
			Console.WriteLine("{0:f2}\n{1:f2}",countGreen,countRed);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}