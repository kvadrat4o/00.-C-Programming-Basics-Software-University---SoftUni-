/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 09:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Greeting
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter your name: ");
			string name = Console.ReadLine();
			Console.WriteLine("Hello, {0}!",name);
		}
	}
}