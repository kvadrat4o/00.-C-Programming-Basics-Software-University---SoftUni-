/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 19/04/2017
 * Time: 16:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace August_03HotelRoom
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("enter month:");
			string month = Console.ReadLine().ToLower();
			//Console.WriteLine("enter month:");
			int nights = int.Parse(Console.ReadLine());
			double studioPrice = 0.00;
			double apartmentPrice = 0.00;
			// TODO: Implement Functionality Here
			
			switch (month)
        {
            case "may":
            case "october":
                studioPrice = 50;
                apartmentPrice = 65;

                if (nights > 14)
                {
                    studioPrice -= 50 * 0.3;
                    apartmentPrice -= 65 * 0.1;
                }
                else if (nights > 7)
                {
                    studioPrice -= 50 * 0.05;
                }
                break;
            case "june":
            case "september":
                studioPrice = 75.20;
                apartmentPrice = 68.70;

                if (nights > 14)
                {
                    studioPrice -= 75.20 * 0.2;
                    apartmentPrice -= 68.70 * 0.1;
                }
                break;
            case "july":
            case "august":
                studioPrice = 76;
                apartmentPrice = 77;

                if (nights > 14)
                {
                    apartmentPrice -= 77 * 0.1;
                }
                break;
        }

        double totalApartmentPrice = apartmentPrice * nights;
        double totalStudioPrice = studioPrice * nights;

        Console.WriteLine("Apartment: {0:F2} lv.", totalApartmentPrice);
        Console.WriteLine("Studio: {0:F2} lv.", totalStudioPrice);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}