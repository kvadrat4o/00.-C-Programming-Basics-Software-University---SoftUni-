/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 17/03/2017
 * Time: 14:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DrawingFiguresWithLoops
{
    class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(new String('*', 10));
            }
        }
    }
}