/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 14:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MetricConverter
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter the number here: ");
			double number = double.Parse(Console.ReadLine());
			//Console.WriteLine("Enter the initial metric here: ");
			string initialMetric = Console.ReadLine().ToLower();
			//Console.WriteLine("Enter the end metric here: ");
			string endMetric = Console.ReadLine().ToLower();
			double finalValue=0;
			if (initialMetric == "m")
            {
				switch (endMetric)
                {
					case "mm":
						finalValue=1000*number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "cm":
						finalValue=100*number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mi":
						finalValue=0.000621371192*number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "in":
						finalValue=39.3700787*number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "km":
						finalValue=number/1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "ft":
						finalValue=3.2808399*number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "yd":
						finalValue=1.0936133*number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "m":
						finalValue=number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					default:
                    	Console.WriteLine("Default case");
                    break;
				}
			}
			else if (initialMetric == "mm")
            {
				switch (endMetric)
                {
					case "m":
						finalValue=number/1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "cm":
						finalValue=number/10;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mi":
					finalValue=(number/1000)*0.000621371192;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "in":
					finalValue=(number/1000)*39.3700787;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "km":
					finalValue=(number/1000)/1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "ft":
					finalValue=(number/1000)*3.2808399;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "yd":
					finalValue=(number/1000)*1.0936133;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mm":
						finalValue=number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					default:
                    	Console.WriteLine("Default case");
                    break;
				}
			}
			else if (initialMetric == "cm")
            {
				switch (endMetric)
                {
					case "m":
						finalValue=(number/100);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mm":
						finalValue=(number/100)*1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mi":
						finalValue=0.000621371192*(number/100);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "in":
						finalValue=39.3700787*(number/100);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "km":
						finalValue=(number/100)/1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "ft":
						finalValue=3.2808399*(number/100);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "yd":
						finalValue=1.0936133*(number/100);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "cm":
						finalValue=number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					default:
                    	Console.WriteLine("Default case");
                    break;
				}
			}
			else if (initialMetric == "mi")
            {
				switch (endMetric)
                {
					case "m":
						finalValue=number/0.000621371192;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "cm":
					finalValue=(number/0.000621371192)*100;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mm":
					finalValue=(number/0.000621371192)*1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "in":
					finalValue=39.3700787*(number/0.000621371192);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "km":
					finalValue=(number/0.000621371192)/1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "ft":
					finalValue=3.2808399*(number/0.000621371192);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "yd":
					finalValue=1.0936133*(number/0.000621371192);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mi":
						finalValue=number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					default:
                    	Console.WriteLine("Default case");
                    break;
				}
			}
			else if (initialMetric == "in")
            {
				switch (endMetric)
                {
					case "m":
						finalValue=(number/39.3700787);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "cm":
						finalValue=(number/39.3700787)*100;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mi":
						finalValue=0.000621371192*(number/39.3700787);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mm":
						finalValue=(number/39.3700787)*1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "km":
						finalValue=(number/39.3700787)/1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "ft":
						finalValue=3.2808399*(number/39.3700787);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "yd":
						finalValue=1.0936133*(number/39.3700787);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "in":
						finalValue=number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					default:
                    	Console.WriteLine("Default case");
                    break;
				}
			}
			else if (initialMetric == "km")
            {
				switch (endMetric)
                {
					case "m":
						finalValue=(number*1000);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "cm":
						finalValue=(number*1000)*100;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mi":
						finalValue=0.000621371192*(number*1000);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mm":
						finalValue=(number*1000)*1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "in":
						finalValue=39.3700787*(number*1000);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "ft":
						finalValue=3.2808399*(number*1000);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "yd":
						finalValue=1.0936133*(number*1000);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "km":
						finalValue=number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					default:
                    	Console.WriteLine("Default case");
                    break;
				}
			}
			else if (initialMetric == "ft")
            {
				switch (endMetric)
                {
					case "m":
						finalValue=(number/3.2808399);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "cm":
						finalValue=(number/3.2808399)*100;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mi":
						finalValue=0.000621371192*(number/3.2808399);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mm":
						finalValue=(number/3.2808399)*1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "km":
						finalValue=(number/3.2808399)/1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "in":
						finalValue=39.3700787*(number/3.2808399);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "yd":
						finalValue=1.0936133*(number/3.2808399);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "ft":
						finalValue=number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					default:
                    	Console.WriteLine("Default case");
                    break;
				}
			}
			else if (initialMetric == "yd")
            {
				switch (endMetric)
                {
					case "m":
						finalValue=(number/1.0936133);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "cm":
						finalValue=(number/1.0936133)*100;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mi":
						finalValue=0.000621371192*(number/1.0936133);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "mm":
						finalValue=(number/1.0936133)*1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "km":
						finalValue=(number/1.0936133)/1000;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "ft":
						finalValue=3.2808399*(number/1.0936133);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "in":
						finalValue=39.3700787*(number/1.0936133);
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					case "yd":
						finalValue=number;
						Console.WriteLine(finalValue+" "+endMetric);
					break;
					default:
                   		Console.WriteLine("Default case");
                    break;
				}
			}
		}
	}
}