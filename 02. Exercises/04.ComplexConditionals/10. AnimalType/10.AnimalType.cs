/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 11:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AnimalType
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter animal name: ");
			string animal = Console.ReadLine().ToLower();
			if (animal=="dog")
            {
				Console.WriteLine("mammal");
			}
			else if (animal=="crocodile")
            {
				Console.WriteLine("reptile");
			}
			else if (animal=="tortoise")
            {
				Console.WriteLine("reptile");
			}
			else if (animal=="snake")
            {
				Console.WriteLine("reptile");
			}
			else
            {
				Console.WriteLine("unknown");
			}
		}
	}
}