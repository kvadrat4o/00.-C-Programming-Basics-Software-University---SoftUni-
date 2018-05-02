/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 13:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace HunderdToTwoHundreds
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter your number here: ");
			int entNumber = int.Parse(Console.ReadLine());
			if (entNumber<100)
            {
				Console.WriteLine("Less than 100");
			}
			else if ((entNumber>=100)&&(entNumber<=200))
            {
				Console.WriteLine("Between 100 and 200");
			}
			else if (entNumber>200)
            {
				Console.WriteLine("Greater than 200");
			}
		}
	}
}