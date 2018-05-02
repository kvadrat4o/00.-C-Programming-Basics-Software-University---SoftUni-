/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 09:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SimpleConditions
{
	class Program
	{
		public static void Main(string[] args)
		{
			double grade = double.Parse(Console.ReadLine());
			if (grade >= 5.50) {
				Console.WriteLine("Excellent!");
			}
		}
	}
}