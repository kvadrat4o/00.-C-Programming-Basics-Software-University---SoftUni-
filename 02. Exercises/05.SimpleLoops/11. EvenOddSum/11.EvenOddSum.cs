/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 16/03/2017
 * Time: 09:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EvenOddSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            double num;
            double oddsum = 0.0;
            double oddmin = 1000000;
            double oddmax = -1000000;
            double evensum = 0.0;
            double evenmin = 1000000;
            double evenmax = -1000000;
            if (double.TryParse(Console.ReadLine(), out num))
            {
                if (num < 0)
                {
                    Console.WriteLine("Error");
                }
                else if (num == 0)
                {
                    Console.WriteLine("OddSum=" + num);
                    Console.WriteLine("OddMin=No");
                    Console.WriteLine("OddMax=No");
                    Console.WriteLine("EvenSum=" + num);
                    Console.WriteLine("EvenMin=No");
                    Console.WriteLine("EvenMax=No");
                }
                else if (num == 1)
                {
                    double number = double.Parse(Console.ReadLine());
                    Console.WriteLine("OddSum=" + number);
                    Console.WriteLine("OddMin=" + number);
                    Console.WriteLine("OddMax=" + number);
                    Console.WriteLine("EvenSum=0");
                    Console.WriteLine("EvenMin=No");
                    Console.WriteLine("EvenMax=No");
                }
                else
                {
                    for (int i = 1; i <= num; i++)
                    {
                        double value;
                        if (double.TryParse(Console.ReadLine(), out value))
                        {
                            if (i % 2 != 0)
                            {
                                oddsum += value;
                                if (value > oddmax)
                                {
                                    oddmax = value;
                                }
                                if (value < oddmin)
                                {
                                    oddmin = value;
                                }
                            }
                            if (i % 2 == 0)
                            {
                                evensum += value;
                                if (value > evenmax)
                                {
                                    evenmax = value;
                                }
                                if (value < evenmin)
                                {
                                    evenmin = value;
                                }
                            }
                        }
                        else
                        {
                            i--;
                        }
                    }
                    if (num == 0)
                    {
                        Console.WriteLine("Oddsum = 0,\n Oddmin = No,\n Oddmax = No,\n Evensum = 0,\n Evenmin = No,\n Evenmax = No");
                    }
                    else if (num == 1)
                    {
                        Console.WriteLine("Oddsum = {0},\n Oddmin = {1},\n Oddmax = {2},\n Evensum = 0,\n Evenmin = No,\n Evenmax = No", oddsum, oddmin, oddmax);
                    }
                    else
                    {
                        Console.WriteLine("Oddsum = {0},\n Oddmin = {1},\n Oddmax = {2},\n Evensum = {3},\n Evenmin = {4},\n Evenmax = {5}", oddsum, oddmin, oddmax, evensum, evenmin, evenmax);
                    }
                }
            }
        }
    }
}