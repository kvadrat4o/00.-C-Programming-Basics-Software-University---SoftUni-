/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 09:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ExcellentOrNot
{
	class Program
	{
		public static void Main(string[] args)
		{
			double grade = double.Parse(Console.ReadLine());
			if (grade >= 5.50)
            {
				Console.WriteLine("Excellent!");
			}
			else
            {
				Console.WriteLine("Not excellent.");
			}
			
		}
	}
}