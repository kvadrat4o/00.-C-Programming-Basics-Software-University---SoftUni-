/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 14:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SumNumbers
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter count of numbers: ");
			int count = int.Parse(Console.ReadLine());
			int sum = 0;
			for (int i=0;i<count;i++)
            {
				int number = int.Parse(Console.ReadLine());
				sum += number;
			}
			Console.WriteLine(sum);
		}
	}
}