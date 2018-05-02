/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 23/03/2017
 * Time: 10:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace March_Morning_04TrainerSalary
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Console.WriteLine("enter count lectures: ");
			double countLectures = double.Parse(Console.ReadLine());
			//Console.WriteLine("enter budget: ");
			double budget = double.Parse(Console.ReadLine());
			double salary,counTrofon,countRoyal,countRoli,countSino,countJelev,countDefault,salaryJelev,salaryOthers,salarySino,salaryRoli,salaryRoyal,salaryTrofon;
			countDefault=0;
			countJelev=0;
			counTrofon=0;
			countRoli=0;
			countRoyal=0;
			countSino=0;
			//Console.WriteLine("Enter lecturer: ");
			for (int i = 0; i < countLectures; i++) {
				string lectureTeacher = Console.ReadLine().ToLower();
				switch (lectureTeacher) {
					case "trofon":
						counTrofon++;
						break;
					case "roli":
						countRoli++;
						break;
					case "sino":
						countSino++;
						break;
					case "jelev":
						countJelev++;
						break;
					case "royal":
						countRoyal++;
						break;
					default:
						countDefault++;
						break;
				}
			}
			salary = budget/countLectures;
			salaryJelev = salary*countJelev;
			salaryOthers = salary*countDefault;
			salarySino = salary*countSino;
			salaryRoli = salary*countRoli;
			salaryRoyal = salary*countRoyal;
			salaryTrofon = salary*counTrofon;
			Console.WriteLine("Jelev salary: {0:f2} lv\nRoYaL salary: {1:f2} lv\nRoli salary: {2:f2} lv\nTrofon salary: {3:f2} lv\nSino salary: {4:f2} lv\nOthers salary: {5:f2} lv\n",salaryJelev,salaryRoyal,salaryRoli,salaryTrofon,salarySino,salaryOthers);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}