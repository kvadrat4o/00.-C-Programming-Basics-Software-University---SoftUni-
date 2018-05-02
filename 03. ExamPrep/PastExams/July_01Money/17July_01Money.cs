/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 10/04/2017
 * Time: 10:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace July_01Money
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter BTC: ");
			int btc = int.Parse(Console.ReadLine());
			//Console.WriteLine("enter CHY: ");
			double chy = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter comission: ");
			double comission = double.Parse(Console.ReadLine())/100.00;
			double toEur,chyToLv,btcToLv,tax,chyToUsd;
			btcToLv = btc*1168.0;
			chyToUsd = chy*0.15;
			chyToLv = chyToUsd*1.76;
			toEur = (chyToLv+btcToLv)/1.95;
			tax = toEur*comission;
			toEur -= toEur*comission;
			Console.WriteLine(toEur);
			Console.ReadKey(true);
		}
	}
}


		//int bitcoins = int.Parse(Console.ReadLine());
        //var yuans = double.Parse(Console.ReadLine());
        //var commision = double.Parse(Console.ReadLine()) / 100.00;

        //var bitcoinsInLeva = bitcoins * 1168.0;
        //var yuansToDollars = yuans * 0.15;
        //var dollarsToLeva = yuansToDollars * 1.76;

        //var levas = bitcoinsInLeva + dollarsToLeva;
        //var euros = levas / 1.95;
        //euros -= commision * euros;
        //Console.WriteLine(euros);