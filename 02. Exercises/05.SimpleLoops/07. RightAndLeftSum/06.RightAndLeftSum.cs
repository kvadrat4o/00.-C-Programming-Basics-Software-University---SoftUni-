/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 15:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RightAndLeftSum
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter count of numbers: ");
			int count = int.Parse(Console.ReadLine());
			int leftSum = 0;
			int rightSum = 0;
			for (int i=0;i<count;i++)
            {
				int number = int.Parse(Console.ReadLine());
				rightSum +=number;
				
			}
			for (int i=0;i<count;i++)
            {
				int number = int.Parse(Console.ReadLine());
				leftSum +=number;
				
			}
			if (rightSum==leftSum)
            {
				Console.WriteLine("Yes, sum = {0}",rightSum);
			}
			else
            {
				Console.WriteLine("No, diff = {0}",Math.Abs(leftSum - rightSum));
			}
		}
	}
}