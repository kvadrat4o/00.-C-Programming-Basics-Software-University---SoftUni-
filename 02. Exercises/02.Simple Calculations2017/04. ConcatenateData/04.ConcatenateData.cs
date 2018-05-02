/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 10:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ConcatenateData
{
	class Program
	{
		public static void Main(string[] args)
		{
			string firstName = Console.ReadLine();
			string lastName = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());
			string town = Console.ReadLine();
			Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.",firstName,lastName,age,town);
		}
	}
}