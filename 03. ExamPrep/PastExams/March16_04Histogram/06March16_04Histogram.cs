/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 05/04/2017
 * Time: 10:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March16_04Histogram
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter a number: ");
			int num = int.Parse(Console.ReadLine());
			int p1,p2,p3,p4,p5;
			p1=0;
			p2=0;
			p5=0;
			p4=0;
			p3=0;
			for (int i = 0; i < num; i++) {
				int n = int.Parse(Console.ReadLine());
				if (n<200) {
					p1++;
				}
				else if ((200<=n)&&(n<=399))
				{
					p2++;
				}
				else if ((400<=n)&&(n<=599)) {
					p3++;
				}
				else if ((600<=n)&&(n<=799)) {
					p4++;
				}
				else if (n>=800) {
					p5++;
				}
			}
			double p1Percent = p1*100.0/ num;
	        double p2Percent = p2*100.0/ num;
	        double p3Percent = p3*100.0/ num;
	        double p4Percent = p4*100.0/ num;
	        double p5Percent = p5*100.0/ num;
			Console.WriteLine("{0:f2}%\n{1:f2}%\n{2:f2}%\n{3:f2}%\n{4:f2}%\n",p1Percent,p2Percent,p3Percent,p4Percent,p5Percent);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}