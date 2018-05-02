/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 12:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Globalization;

namespace EarthAfter1000Days
{
	class Program
	{
		public static void Main(string[] args)
		{
		
		string format = "dd-MM-yyyy";
        string value = Console.ReadLine();
        DateTime userBirthday = DateTime.ParseExact(value, format, null);
        Console.WriteLine(userBirthday.AddDays(999).ToString("dd-MM-yyyy"));
		}
	}
}