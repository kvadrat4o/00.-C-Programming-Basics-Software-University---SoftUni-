/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 13:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EqualWords
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter your word here: ");
			string firstWord = Console.ReadLine();
			//Console.WriteLine("Enter other word here: ");
			string secondWord = Console.ReadLine();
			firstWord = firstWord.ToLower();
			secondWord = secondWord.ToLower();
			if (firstWord==secondWord)
            {
				Console.WriteLine("yes");
			}
			else
            {
				Console.WriteLine("no");
			}
		}
	}
}