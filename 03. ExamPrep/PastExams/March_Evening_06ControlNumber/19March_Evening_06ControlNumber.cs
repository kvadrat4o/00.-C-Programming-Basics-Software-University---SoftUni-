/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 23/03/2017
 * Time: 11:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_Evening_06ControlNumber
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter first number N: ");
			int N = int.Parse(Console.ReadLine());
			//Console.WriteLine("enter second number M: ");
			int M = int.Parse(Console.ReadLine());
			//Console.WriteLine("enter control number number C: ");
			int C = int.Parse(Console.ReadLine());
			int sum,counter;
			sum = 0;
			counter = 0;
			for (int i = 1; i<=N; i++) {
				for (int j = M; j>=1; j--) {
					sum = N*2+M*3;
					counter++;
					if (sum>=C) {
						Console.WriteLine("{0} moves \nScore: {1} >= {2}",counter,sum,C);
						break;
					}
				}
				if (sum>=C) {
						break;
					}
				counter++;
				
			}
			if (sum<C) {
				
				Console.WriteLine("{0} moves",counter);
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}