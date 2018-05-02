/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 13:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PasswordGuess
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter your passowrd here: ");
			string enteredPass = Console.ReadLine();
			string oldPass = "s3cr3t!P@ssw0rd";
			if (enteredPass==oldPass)
            {
				Console.WriteLine("Welcome");
			}
			else
            {
				Console.WriteLine("Wrong password!");
			}
		}
	}
}