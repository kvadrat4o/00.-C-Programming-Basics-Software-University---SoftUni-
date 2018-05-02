/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 15/03/2017
 * Time: 10:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MinNumber
{
	class Program
	{
		public static void Main(string[] args)
		{
			/Console.WriteLine("Enter count of numbers: ");
			int count = int.Parse(Console.ReadLine());
			int number = int.Parse(Console.ReadLine());
			int min = number;
			for (int i=0;i<count-1;i++)
            {
				number = int.Parse(Console.ReadLine());
				if (number<min)
                {
					min = number;
				}
			}
			Console.WriteLine(min);
		}
	}
}