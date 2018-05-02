/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 18:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PersonalTitles
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter age: ");
			double age = double.Parse(Console.ReadLine());
			//Console.WriteLine("Enter gender: ");
			string gender = Console.ReadLine();
			gender = gender.ToLower();
			if (gender=="m")
            {
				if (age<16)
                {
					Console.WriteLine("Master");
				}
				else
                {
					Console.WriteLine("Mr.");
				}
			}
			else if (gender=="f")
            {
				if (age<16)
                {
					Console.WriteLine("Miss");
				}
				else
                {
					Console.WriteLine("Ms");
				}
			}
		}
	}
}