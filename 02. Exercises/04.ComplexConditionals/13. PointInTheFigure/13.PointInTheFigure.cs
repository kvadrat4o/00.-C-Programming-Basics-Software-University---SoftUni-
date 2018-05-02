/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 12:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PointInTheFigure
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter height: ");
			int h = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter x coordinate: ");
			int x = int.Parse(Console.ReadLine());
			//Console.WriteLine("Enter y coordinate: ");
			int y = int.Parse(Console.ReadLine());
			if ((x > h) && (x < 2 * h) && (y == h))
            { 
				Console.WriteLine("inside");
			}
		    else if ((x >= h) && (x <= 2 * h) && (y >= h) && (y <= 4 * h))
            {
				
		            if ((x > h) && (x < 2 * h) && (y > h) && (y < 4 * h))
                    { 
		    		Console.WriteLine("inside"); 
		    		}
		            else if ((x >= h) && (x <= 2 * h) || (y >= h) && (y <= 4 * h))
                    {
		    		Console.WriteLine("border");
			    	}
		    }
		    else if ((x >= 0) && (x <= 3 * h) && (y >= 0) && (y <= h))
            {
				
		            if ((x > 0) && (x < 3 * h) && (y > 0) && (y < h))
                    { 
					Console.WriteLine("inside"); 
					}
		            else if ((x >= 0) && (x <= 3 * h) || (y >= 0) && (y <= h))
                    { 
					Console.WriteLine("border"); 
					}

            }
		    else
            { 
		    	Console.WriteLine("outside"); 
		    }
		}
	}
}