/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 09/03/2017
 * Time: 11:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CurrencyConverter
{
	class Program
	{
		public static void Main(string[] args)
		{
			double amount = double.Parse(Console.ReadLine());
			string initialCurrency = Console.ReadLine();
			string lastCurrency = Console.ReadLine();
			double lastAmount = 0;
			
			if (initialCurrency=="BGN")
            {
				switch (lastCurrency)
				{
                case "USD":
					lastAmount=amount/1.79549;
					Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
                case "EUR":
                    lastAmount=amount/1.95583;
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
                case "GBP":
                    lastAmount=amount/2.53405;
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
                default:
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
            	}
			}
			else if (initialCurrency=="EUR")
            {
				switch (lastCurrency)
				{
                case "USD":
						lastAmount=(amount*1.95583)/1.79549;
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
                case "BGN":
                    lastAmount=amount*1.95583;
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
                case "GBP":
                    lastAmount=(amount*1.95583)/2.53405;
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
                default:
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
            	}
			}
			else if (initialCurrency=="USD")
            {
				switch (lastCurrency)
				{
                case "BGN":
					lastAmount=amount*1.79549;
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
                case "EUR":
                    lastAmount=(amount*1.79549)/1.95583;
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
                case "GBP":
                    lastAmount=(amount*1.79549)/2.53405;
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
                default:
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
            	}
			}
			else if (initialCurrency=="GBP")
            {
				switch (lastCurrency)
				{
				case "USD":
						lastAmount=(amount*2.53405)/1.79549;
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
                case "EUR":
                    lastAmount=(amount*2.53405)/1.95583;
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
                case "BGN":
                    lastAmount=amount*2.53405;
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
                default:
                    Console.WriteLine("{0}",Math.Round(lastAmount,2));
                    break;
            	}
			}
		}
	}
}