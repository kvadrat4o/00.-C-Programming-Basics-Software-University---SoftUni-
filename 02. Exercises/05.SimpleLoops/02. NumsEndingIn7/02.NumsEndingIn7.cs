/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 14/03/2017
 * Time: 14:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NumsEndingIn7
{
	class Program
	{
		public static void Main(string[] args)
		{
			for (int i = 0;i<=1000;i++)
            {
				if (i % 10 == 7)
                {
					Console.WriteLine(i);
				}
			}
		}
	}
}