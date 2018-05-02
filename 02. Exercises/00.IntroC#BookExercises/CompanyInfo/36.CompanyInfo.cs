/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 24/03/2017
 * Time: 15:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CompanyInfo
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter name: ");
			string name = Console.ReadLine();
			Console.WriteLine("enter address: ");
			string address = Console.ReadLine();
			Console.WriteLine("enter phone number: ");
			int phone  = int.Parse(Console.ReadLine());
			Console.WriteLine("enter website URL: ");
			string website = Console.ReadLine();
			Console.WriteLine("enter fax number: ");
			int fax  = int.Parse(Console.ReadLine());
			Console.WriteLine("enter manager: ");
			string manager = Console.ReadLine();
			
			Console.WriteLine("Name: {0}\nAddress: {1}\nPhone: {2}\nWebsite: {3}\nFax: {4}\nManager: {5}",name,address,phone,website,fax,manager);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}