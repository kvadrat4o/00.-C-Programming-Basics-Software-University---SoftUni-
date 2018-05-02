/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 28/03/2017
 * Time: 11:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace February_03FallenInLove
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter N: ");
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++) {
				Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}",'#',new String('~',i),'#',new String('.',2*n-2*i),'#',new String('.',2*i),'#',new String('.',2*n-2*i),'#',new String('~',i),'#');
			}
			for (int i = 0; i < n; i++) {
				Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}",new String('.',1+2*i),'#',new String('~',n-i),'#',new String('.',2*n-2*i),'#',new String('~',n-i),'#',new String('.',1+2*i));
			}
			Console.WriteLine("{0}{1}{2}",new String('.',2*n+1),new String('#',4),new string('.',2*n+1));
			for (int i = 0; i < n; i++) {
				Console.WriteLine("{0}{1}{2}",new String('.',2*n+2),new String('#',2),new string('.',2*n+2));
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}