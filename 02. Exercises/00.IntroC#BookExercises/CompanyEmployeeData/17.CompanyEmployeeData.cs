/*
 * Created by SharpDevelop.
 * User: dvasilev
 * Date: 1/26/2017
 * Time: 9:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CompanyEmployeeData
{
	class Program
	{
		public static void Main(string[] args)
		{
			string firstName = "Dimitar";
			string lastName = "Vasilev";
			int age = 29;
			bool isMale = true;
			long identification = 123456789L;
			Console.WriteLine("You are {0} {1}, {2}years old emplyee. Are you a male? {3}. Your ID is {4}",firstName,lastName,age,isMale,identification);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}