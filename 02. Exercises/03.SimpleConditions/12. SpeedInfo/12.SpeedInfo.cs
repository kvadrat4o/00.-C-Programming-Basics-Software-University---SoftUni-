﻿/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 13:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SpeedInfo
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter speed:");
			double speed = double.Parse(Console.ReadLine());
			if (speed<=10)
            {
				Console.WriteLine("slow");
			}
			else if ((speed>10)&&(speed<=50))
            {
				Console.WriteLine("average");
			}
			else if ((speed>50)&&(speed<=150))
            {
				Console.WriteLine("fast");
			}
			else if ((speed>150)&&(speed<=1000))
            {
				Console.WriteLine("ultra fast");
			}
			else if (speed>1000)
            {
				Console.WriteLine("extremely fast");
			}
		}
	}
}