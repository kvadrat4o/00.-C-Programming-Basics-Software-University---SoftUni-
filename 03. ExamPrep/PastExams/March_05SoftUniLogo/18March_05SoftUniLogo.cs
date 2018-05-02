/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 22/03/2017
 * Time: 11:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_05SoftUniLogo
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter side length: ");
			int num = int.Parse(Console.ReadLine());
			int diezCnt=1;
		
			for (int i = 0; i <=2*num-1; i++) {
				Console.WriteLine("{0}{1}{2}",new String ('.',(12*num-5)/2-(diezCnt/2)),new String('#',diezCnt),new String('.',(12*num-5)/2-(diezCnt/2)));
				diezCnt+=6;
			}
			//Console.WriteLine("{0}",new String('#',12*num-5));
			for (int i = 1; i <=num-2; i++) {
				diezCnt=12*num-5;
				Console.WriteLine("{0}{1}{2}{3}",'|',new String('.',((12*num-5)/2-(diezCnt/2))+3*i-1),new String('#',diezCnt-6*i),new String('.',((12*num-5)/2-(diezCnt/2))+3*i));
				
			}
			for (int i = 0; i < num-1; i++) {
				Console.WriteLine("{0}{1}{2}{3}",'|',new String('.',3*num-3-1),new String('#',12*num-5-2*(3*num-3)),new String('.',3*num-3));
			}
			Console.WriteLine("{0}{1}{2}{3}",'@',new String('.',3*num-3-1),new String('#',12*num-5-2*(3*num-3)),new String('.',3*num-3));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}