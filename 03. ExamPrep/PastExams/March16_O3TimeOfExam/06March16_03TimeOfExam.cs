/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 04/04/2017
 * Time: 11:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March16_O3TimeOfExam
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("exam hour: ");
			int examHour = int.Parse(Console.ReadLine());
			Console.WriteLine("exam hour: ");
			int examMinutes = int.Parse(Console.ReadLine());
			Console.WriteLine("exam hour: ");
			int arrivalHour = int.Parse(Console.ReadLine());
			Console.WriteLine("exam hour: ");
			int arrivalMinutes = int.Parse(Console.ReadLine());
			int examTime = examHour * 60 + examMinutes;
	        int studentTime = arrivalHour * 60 + arrivalMinutes;
	        int minutesDifference = studentTime - examTime;
	
	        if (minutesDifference < -30)
	        {
	        	Console.WriteLine("Early");
	        }
	            
	        else if (minutesDifference <= 0)
	        {
	        	Console.WriteLine("On time");
	        }
	        else
	        {
	        	Console.WriteLine("Late");
	        }
	
	        if (minutesDifference != 0)
	        {
	            double hours = Math.Abs(minutesDifference / 60);
	            double minutes = Math.Abs(minutesDifference % 60);
	            if (hours > 0)
	            {
	                if (minutes < 10)
	                    Console.Write(hours + ":0" + minutes + " hours");
	                else
	                    Console.Write(hours + ":" + minutes + " hours");
	            }
	            else
	            {
	            	Console.Write(minutes + " minutes");
	            }
	            if (minutesDifference < 0)
	            {
	            	Console.WriteLine(" before the start");
	            }
	            else
	            {
	            	Console.WriteLine(" after the start");
	            }
	        }
		}
	}
}