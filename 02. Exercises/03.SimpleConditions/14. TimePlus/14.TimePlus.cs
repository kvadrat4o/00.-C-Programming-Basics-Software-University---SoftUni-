/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 14:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TimePlus
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter hours: ");
			int hours = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter hours: ");
			int mins = int.Parse(Console.ReadLine());
			int adMins = mins+15;
			int resultHours=hours;
			
			if (hours>=0 && hours<=23 && adMins >= 60)
            {
                hours++;
                if (hours == 24)
                {
                    hours = 0;
                }
                mins = (adMins) % 60;
                Console.WriteLine("{0}:{1}", hours,mins.ToString().PadLeft(2,'0'));
        	}
            else
            {
                mins = (adMins) % 60;
                Console.WriteLine("{0}:{1}", hours,mins.ToString().PadLeft(2,'0'));
            }
		}
	}
}