/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 09:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GreaterNumber
{
	class Program
	{
		public static void Main(string[] args)
		{
			int numberOne = int.Parse(Console.ReadLine());
			int numberTwo = int.Parse(Console.ReadLine());
			if (numberOne > numberTwo)
            {
				Console.WriteLine(numberOne);
			}
			else
            {
				Console.WriteLine(numberTwo);
			}
		}
	}
}