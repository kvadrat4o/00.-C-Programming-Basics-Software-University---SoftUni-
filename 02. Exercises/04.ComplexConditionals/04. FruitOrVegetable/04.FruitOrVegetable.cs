/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 09:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace FruitOrVegetable
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Please enter your word: ");
			string word = Console.ReadLine();
			word = word.ToLower();
			switch (word)
            {
				case "banana":
					Console.WriteLine("fruit");
				break;
				case "apple":
					Console.WriteLine("fruit");
				break;
				case "kiwi":
					Console.WriteLine("fruit");
				break;
				case "cherry":
					Console.WriteLine("fruit");
				break;
				case "grapes":
					Console.WriteLine("fruit");
				break;
				case "tomato":
					Console.WriteLine("vegetable");
				break;
				case "cucumber":
					Console.WriteLine("vegetable");
				break;
				case "pepper":
					Console.WriteLine("vegetable");
				break;
				case "carrot":
					Console.WriteLine("vegetable");
				break;
				case "lemon":
					Console.WriteLine("fruit");
				break;
				default:
				Console.WriteLine("unknown");
				break;
			}
		}
	}
}