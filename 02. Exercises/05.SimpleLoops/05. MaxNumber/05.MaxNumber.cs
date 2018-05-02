/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 15:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MaxNumber
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter count of numbers: ");
			int count = int.Parse(Console.ReadLine());
			int number = int.Parse(Console.ReadLine());
			int max = number;
			for (int i=0;i<count-1;i++)
            {
				number = int.Parse(Console.ReadLine());
				if (number>max)
                {
					max = number;
				}
			}
			Console.WriteLine(max);
		}
	}
}