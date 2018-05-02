/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/26/2017
 * Time: 3:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;


namespace Char_Triangle
{
	class Program
	{
		public static void Main(string[] args)
		{
			char a = '\u00A9';
			
			Console.OutputEncoding = Encoding.Unicode;
			Console.WriteLine("   "+a+"   ");
            Console.WriteLine("  "+a+" "+a+"  ");
            Console.WriteLine(" "+a+"   "+a+" ");
            Console.WriteLine(a+" "+a+" "+a+" "+a);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}