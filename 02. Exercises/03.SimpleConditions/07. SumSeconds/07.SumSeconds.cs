/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 12:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SumSeconds
{
	class Program
	{
		public static void Main(string[] args)
		{
			int first = int.Parse(Console.ReadLine());
			int second1 = int.Parse(Console.ReadLine());
			int third = int.Parse(Console.ReadLine());
			int sumAll = first+second1+third;
			int hours = sumAll/60;
			if (sumAll<=59)
            {
				if (sumAll<10)
                {
				Console.WriteLine("0:0{0}",sumAll);
				}
				else
                {
					Console.WriteLine("0:{0}",sumAll);
				}
			}
			else if ((sumAll>59)&&(sumAll<=119))
            {
				if ((sumAll-60)<10)
                {
				Console.WriteLine("{0}:0{1}",hours,sumAll-60);
				}
				else
                {
					Console.WriteLine("{0}:{1}",hours,sumAll-60);
				}
			}
			else if ((sumAll>119)&&(sumAll<=179))
            {
				if ((sumAll-120)<10)
                {
					Console.WriteLine("{0}:0{1}",hours,sumAll-120);
				}
				else
                {
					Console.WriteLine("{0}:{1}",hours,sumAll-120);
				}
			}
			
		}
	}
}