/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 14:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AreaOfFigures
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Please enter the type of the figure: ");
			string figure = Console.ReadLine();
			switch (figure)
            {
                case "triangle":
					double side = double.Parse(Console.ReadLine());
					double height = double.Parse(Console.ReadLine());
					double triangleArea = (side*height)/2;
					Console.WriteLine(Math.Round(triangleArea,3));
                    break;
                case "rectangle":
                    double a = double.Parse(Console.ReadLine());
					double b = double.Parse(Console.ReadLine());
					double rectArea = a*b;
					Console.WriteLine(Math.Round(rectArea,3));
                    break;
                    case "square":
                    double squareSide = double.Parse(Console.ReadLine());
					double squareArea = squareSide*squareSide;
					Console.WriteLine(Math.Round(squareArea,3));
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
					double circleArea = Math.PI*radius*radius;
					Console.WriteLine(Math.Round(circleArea,3));
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }	
		}
	}
}