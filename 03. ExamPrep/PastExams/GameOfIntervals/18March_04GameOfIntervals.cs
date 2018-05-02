/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 21/03/2017
 * Time: 15:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GameOfIntervals
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter number of moves: ");
			double nuMoves = double.Parse(Console.ReadLine());
			double sum,points,countOne,counTwo,counThree,countFour,countFive,countSix;
			sum = 0;
			countOne=0;
			counTwo=0;
			counThree=0;
			countFour=0;
			countFive=0;
			countSix=0;
			for (int i = 0; i < nuMoves; i++) {
				double enteredNum = double.Parse(Console.ReadLine());
				if (enteredNum<0||enteredNum>50) {
					sum=sum/2;
					countOne++;
				}
				if (enteredNum>=0&&enteredNum<=9) {
					points = enteredNum*20/100;
					sum+=points;
					counTwo++;
				}
				if (enteredNum>=10&&enteredNum<=19) {
					points = enteredNum*30/100;
					sum+=points;
					counThree++;
				}
				if (enteredNum>=20&&enteredNum<=29) {
					points = enteredNum*40/100;
					sum+=points;
					countFour++;
				}
				if (enteredNum>=30&&enteredNum<=39) {
					points = 50;
					sum+=points;
					countFive++;
				}
				if (enteredNum>=40&&enteredNum<=50) {
					points = 100;
					sum+=points;
					countSix++;
				}
			}
			countOne*=100/nuMoves;
			counTwo*=100/nuMoves;
			counThree*=100/nuMoves;
			countFour*=100/nuMoves;
			countFive*=100/nuMoves;
			countSix*=100/nuMoves;
			Console.WriteLine("{0:f2}\n From 0 to 9: {1:f2}% \n From 10 to 19: {2:f2}% \n From 20 to 29: {3:f2}% \n From 30 to 39: {4:f2}% \n From 40 to 50: {5:f2}% \n Invalid numbers: {6:f2}% \n",sum,counTwo,counThree,countFour,countFive,countSix,countOne);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}