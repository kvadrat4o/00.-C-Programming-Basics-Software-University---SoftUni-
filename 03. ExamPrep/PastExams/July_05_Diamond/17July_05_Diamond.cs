/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 18/04/2017
 * Time: 16:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace July_05_Diamond
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter number");
			int num = int.Parse(Console.ReadLine());
			
			Console.WriteLine("{0}{1}{2}",new String('.',num),new String('*',3*num),new String('.',num));
			for (int i = 0; i < num-1; i++) {
				Console.WriteLine("{0}{1}{2}{3}{4}",new String('.',num-1-i),new String('*',1),new String('.',3*num+2*i),new String('*',1),new String('.',num-1-i));
			}
			Console.WriteLine(new String('*',5*num));
			for (int i = 0; i < 2*num; i++) {
				Console.WriteLine("{0}{1}{2}{3}{4}",new String('.',1+i),new String('*',1),new String('.',5*num-4-2*i),new String('*',1),new String('.',1+i));
			}
			Console.WriteLine("{0}{1}{2}",new String('.',2*num+1),new String('*',num-2),new String('.',2*num+1));
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}