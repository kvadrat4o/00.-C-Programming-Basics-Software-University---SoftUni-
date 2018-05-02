/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 22/03/2017
 * Time: 14:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_06SumOfTwoNumbers
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter begining of the interval: ");
			int beginingInterval = int.Parse(Console.ReadLine());
			//Console.WriteLine("enter end of the interval: ");
			int endInterval = int.Parse(Console.ReadLine());
			//Console.WriteLine("enter magic number: ");
			int magicNum = int.Parse(Console.ReadLine());
			int sum,counter;
			counter = 0;
			sum=0;
			for (int i = beginingInterval; i <=endInterval; i++) {
				for (int j = beginingInterval; j <=endInterval; j++) {
					sum = beginingInterval+j;
					counter++;
				    if (sum==magicNum) {
					    Console.WriteLine("Combination N:{0} ({1} + {2} = {3})",counter,beginingInterval,j,magicNum);
					    break;
				    }
					//counter++;
				}
				beginingInterval+=i;
				if (sum==magicNum) {
					    break;
				}
				//counter++;
			}
			if(sum!=magicNum){
				Console.WriteLine("{0} combinations - neither equals {1}",counter,magicNum);   
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}