/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 18/04/2017
 * Time: 17:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace July_05StopNumber
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter N:");
			int N = int.Parse(Console.ReadLine());
			//Console.WriteLine("enter M:");
			int M = int.Parse(Console.ReadLine());
			//Console.WriteLine("enter S:");
			int S = int.Parse(Console.ReadLine());
			
			for (int i = M; i >= N; i--) {
					if (i % 3 == 0 && i % 2 == 0)
		            {
		                if (S == i)
		                {
		                    break;
		                }
		                Console.Write("{0} ", i);
		            }
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}