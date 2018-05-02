/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 09:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace InvalidNumber
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter a number: ");
			int number = int.Parse(Console.ReadLine());
			if ((number<100)||(number>200))
            {
				if (number!=0)
                {
					Console.WriteLine("invalid");
				}
			}
		}
	}
}