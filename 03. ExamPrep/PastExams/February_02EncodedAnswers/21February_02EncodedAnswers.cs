/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 27/03/2017
 * Time: 17:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace February_02EncodedAnswers
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Enter N: ");
			int N = int.Parse(Console.ReadLine());
			int countA,countB,countC,countD;
			countA=0;
			countB=0;
			countC=0;
			countD=0;
			//int n = int.Parse(Console.ReadLine());
            string result = null;
            
            for (int i = 0; i < N; i++)
            {
                uint answerAsNumber = uint.Parse(Console.ReadLine());
                string answer;

                if (answerAsNumber % 4 == 0)
                {
                    answer = "a";
                    countA++;
                }
                else if (answerAsNumber % 4 == 1)
                {
                    answer = "b";
                    countB++;
                }
                else if (answerAsNumber % 4 == 2)
                {
                    answer = "c";
                    countC++;
                }
                else
                {
                    answer = "d";
                    countD++;
                }

                result += answer + ' ';
            }

            Console.WriteLine(result);
            Console.WriteLine("Answer A: {0}\nAnswer B: {1}\nAnswer C: {2}\nAnswer D: {3}", countA, countB, countC, countD);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}