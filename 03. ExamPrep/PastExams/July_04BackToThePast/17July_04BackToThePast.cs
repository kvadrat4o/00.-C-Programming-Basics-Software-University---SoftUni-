﻿/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 18/04/2017
 * Time: 15:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace July_04BackToThePast
{
	class Program
	{
		public static void Main(string[] args)
		{
		double inheritance = double.Parse(Console.ReadLine());
        int yearToLive = int.Parse(Console.ReadLine());
        int years = 18;

        for (int i = 1800; i <= yearToLive; i++)
        {
            if (i % 2 == 0)
            {
                inheritance -= 12000;
            }
            else
            {
                inheritance -= (12000 + 50 * years);
            }
            years++;
        }
        if (inheritance < 0)
        {
            Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(inheritance));
        }
        else
        {
            Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", inheritance);
        }
		}
	}
}