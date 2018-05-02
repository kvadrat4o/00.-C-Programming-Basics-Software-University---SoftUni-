/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 15/03/2017
 * Time: 09:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VowelSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine().ToLower();
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}