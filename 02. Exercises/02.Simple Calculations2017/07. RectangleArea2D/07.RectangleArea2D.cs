/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 10:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RectangleArea2D
{
	class Program
	{
		public static void Main(string[] args)
		{
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());
			double perimeter,area;
			if (x1<x2)
            {
				if(y1<y2)
                {
					perimeter = 2*((x2-x1)+(y2-y1));
					area =((x2-x1)*(y2-y1)) ;
				}
				else
                {
					perimeter = 2*((x2-x1)+(y1-y2));
					area =((x2-x1)*(y1-y2)) ;
				}
			}
			else
            {
				if(y1<y2)
                {
					perimeter = 2*((x1-x2)+(y2-y1));
					area =((x1-x2)*(y2-y1)) ;
				}
				else
                {
					perimeter = 2*((x1-x2)+(y1-y2));
					area =((x1-x2)*(y1-y2)) ;
				}
			};
			
			Console.Write("{0}\n {1}",area,perimeter);
		}
	}
}