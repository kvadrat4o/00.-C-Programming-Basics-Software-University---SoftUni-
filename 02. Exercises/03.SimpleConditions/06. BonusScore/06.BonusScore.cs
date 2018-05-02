/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 13/03/2017
 * Time: 11:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace BonusScore
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter score: ");
			int score = int.Parse(Console.ReadLine());
			double bonuScore = 0;
			if (score<=100)
            {
				bonuScore=5;
				if (score%2==0)
                {
				bonuScore+=1;
				}
				else if (score%5==0)
                {
					bonuScore+=2;
				}
			}
			else if((score>100)&&(score<=1000))
            {
				bonuScore=0.2*score;
				if (score%2==0)
                {
				bonuScore+=1;
				}
				else if (score%5==0)
                {
					bonuScore+=2;
				}
			}
			else if(score>1000)
            {
				bonuScore=0.1*score;
				if (score%2==0)
                {
				bonuScore+=1;
				}
				else if (score%5==0)
                {
					bonuScore+=2;
				}
			}
			double totalScore = bonuScore+score;
			Console.WriteLine("Bonus score: "+ bonuScore);
			Console.WriteLine("Total score: "+totalScore);
		}
	}
}