/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 23/03/2017
 * Time: 11:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_Evening_05Parallelepiped
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter number: ");
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine("{0}{1}{2}{3}",new String ('+',1),new String('~',num-2), new string('+',1),new string('.',2*num+1));
			for (int i = 0; i < 2*num+1; i++) {
				Console.WriteLine("{0}{1}{2}{3}{4}{5}",new String ('|',1),new string('.',i),new string('\\',1),new String('~',num-2), new string('\\',1),new string('.',2*num-i));	
			}
			for (int i = 0; i < 2*num+1; i++) {
				Console.WriteLine("{0}{1}{2}{3}{4}{5}",new string('.',i),new string('\\',1),new string('.',2*num-i),new String ('|',1),new String('~',num-2), new string('|',1));	
			}
					
			Console.WriteLine("{0}{1}{2}{3}",new string('.',2*num+1),new String ('+',1),new String('~',num-2), new string('+',1));
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}