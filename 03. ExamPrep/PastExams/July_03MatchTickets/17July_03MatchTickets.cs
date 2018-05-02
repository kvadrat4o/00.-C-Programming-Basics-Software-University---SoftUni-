/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 18/04/2017
 * Time: 14:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace July_03MatchTickets
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter budget:");
			int budget = int.Parse(Console.ReadLine());
			//Console.WriteLine("enter budget:");
			string category = Console.ReadLine().ToLower();
			//Console.WriteLine("enter budget:");
			int numPeople = int.Parse(Console.ReadLine());
			double transport = 0.00;
			double diff = budget-transport;
			double ticketPrice = 0.00;
			double totalTicketsCost = 0.00;
			//int totalDiff = 0;
			// TODO: Implement Functionality Here
			switch (category) {
					case "vip":
						ticketPrice = 499.99;
						if (numPeople>=1&&numPeople<=4) {
							transport = budget*0.75;
							diff = budget-transport;
							totalTicketsCost = ticketPrice*numPeople;
							if (totalTicketsCost>diff) {
								Console.WriteLine("Not enough money! You need {0:F2} leva.",Math.Abs(totalTicketsCost-diff));
							}
							else {
								Console.WriteLine("Yes! You have {0:F2} leva left.",Math.Abs(totalTicketsCost-diff));
							}
						}
						if (numPeople>=5&&numPeople<=9) {
							transport = budget*0.60;
							diff = budget-transport;
							totalTicketsCost = ticketPrice*numPeople;
							if (totalTicketsCost>diff) {
								Console.WriteLine("Not enough money! You need {0:F2} leva.",Math.Abs(totalTicketsCost-diff));
							}
							else {
								Console.WriteLine("Yes! You have {0:F2} leva left.",Math.Abs(totalTicketsCost-diff));
							}
						}
						if (numPeople>=10&&numPeople<=24) {
							transport = budget*0.50;
							diff = budget-transport;
							totalTicketsCost = ticketPrice*numPeople;
							if (totalTicketsCost>diff) {
								Console.WriteLine("Not enough money! You need {0:F2} leva.",Math.Abs(totalTicketsCost-diff));
							}
							else {
								Console.WriteLine("Yes! You have {0:F2} leva left.",Math.Abs(totalTicketsCost-diff));
							}
						}
						if (numPeople>=25&&numPeople<=49) {
							transport = budget*0.40;
							diff = budget-transport;
							totalTicketsCost = ticketPrice*numPeople;
							if (totalTicketsCost>diff) {
								Console.WriteLine("Not enough money! You need {0:F2} leva.",Math.Abs(totalTicketsCost-diff));
							}
							else {
								Console.WriteLine("Yes! You have {0:F2} leva left.",Math.Abs(totalTicketsCost-diff));
							}
						}
						if (numPeople>=50) {
							transport = budget*0.25;
							diff = budget-transport;
							totalTicketsCost = ticketPrice*numPeople;
							if (totalTicketsCost>diff) {
								Console.WriteLine("Not enough money! You need {0:F2} leva.",Math.Abs(totalTicketsCost-diff));
							}
							else {
								Console.WriteLine("Yes! You have {0:F2} leva left.",Math.Abs(totalTicketsCost-diff));
							}
						}
						break;
					case "normal":
						ticketPrice = 249.99;
						if (numPeople>=1&&numPeople<=4) {
							transport = budget*0.75;
							diff = budget-transport;
							totalTicketsCost = ticketPrice*numPeople;
							if (totalTicketsCost>diff) {
								Console.WriteLine("Not enough money! You need {0:F2} leva.",Math.Abs(totalTicketsCost-diff));
							}
							else {
								Console.WriteLine("Yes! You have {0:F2} leva left.",Math.Abs(totalTicketsCost-diff));
							}
						}
						if (numPeople>=5&&numPeople<=9) {
							transport = budget*0.60;
							diff = budget-transport;
							totalTicketsCost = ticketPrice*numPeople;
							if (totalTicketsCost>diff) {
								Console.WriteLine("Not enough money! You need {0:F2} leva.",Math.Abs(totalTicketsCost-diff));
							}
							else {
								Console.WriteLine("Yes! You have {0:F2} leva left.",Math.Abs(totalTicketsCost-diff));
							}
						}
						if (numPeople>=10&&numPeople<=24) {
							transport = budget*0.50;
							diff = budget-transport;
							totalTicketsCost = ticketPrice*numPeople;
							if (totalTicketsCost>diff) {
								Console.WriteLine("Not enough money! You need {0:F2} leva.",Math.Abs(totalTicketsCost-diff));
							}
							else {
								Console.WriteLine("Yes! You have {0:F2} leva left.",Math.Abs(totalTicketsCost-diff));
							}
						}
						if (numPeople>=25&&numPeople<=49) {
							transport = budget*0.40;
							diff = budget-transport;
							totalTicketsCost = ticketPrice*numPeople;
							if (totalTicketsCost>diff) {
								Console.WriteLine("Not enough money! You need {0:F2} leva.",Math.Abs(totalTicketsCost-diff));
							}
							else {
								Console.WriteLine("Yes! You have {0:F2} leva left.",Math.Abs(totalTicketsCost-diff));
							}
						}
						if (numPeople>=50) {
							transport = budget*0.25;
							diff = budget-transport;
							totalTicketsCost = ticketPrice*numPeople;
							if (totalTicketsCost>diff) {
								Console.WriteLine("Not enough money! You need {0:F2} leva.",Math.Abs(totalTicketsCost-diff));
							}
							else {
								Console.WriteLine("Yes! You have {0:F2} leva left.",Math.Abs(totalTicketsCost-diff));
							}
						}
						break;
				}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}