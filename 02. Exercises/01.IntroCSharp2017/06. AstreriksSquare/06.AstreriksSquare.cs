/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 09:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AstreriksSquare
{
	class Program
	{
		public static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine(new String ('*', number));
			for (int i = 2; i<=number;i++) {

				if (i==number) {
					Console.WriteLine(new String ('*', number));
				}
				else {
					Console.WriteLine("*{0}*",new String (' ', number - 2));
					
				};
				
			};
		}
	}
}