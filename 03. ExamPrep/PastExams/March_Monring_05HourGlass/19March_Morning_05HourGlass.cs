/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 23/03/2017
 * Time: 11:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_Monring_05HourGlass
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter a number: ");
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine(new String ('*',2*num+1));
			Console.WriteLine("{0}{1}{2}{3}{4}",new String ('.',1),new String('*',1),new String (' ',2*num+1-4),new String ('*',1),new String ('.',1));
			for (int i = 0; i < num-2; i++) {
				Console.WriteLine("{0}{1}{2}{3}{4}",new String ('.',((2*num+1-(2*num+1-6)-2)/2)+i),new String('*',1),new String ('@',2*num+1-6-2*i),new String ('*',1),new String ('.',((2*num+1-(2*num+1-6)-2)/2)+i));
			}
			Console.WriteLine("{0}{1}{2}",new String ('.',num),new String('*',1),new String ('.',num));
			for (int i = 0; i < num-2; i++) {
				Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}",new String ('.',num-1-i),new String('*',1),new String (' ',i),new String ('@',1),new String (' ',i),new String ('*',1),new String ('.',num-1-i));
			}
			Console.WriteLine("{0}{1}{2}{3}{4}",new String ('.',1),new String('*',1),new String ('@',2*num+1-4),new String ('*',1),new String ('.',1));
			Console.WriteLine(new String ('*',2*num+1));
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}