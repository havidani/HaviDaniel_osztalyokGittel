﻿namespace oopgyakorlas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Konyv konyv1 = new ("A kis herceg", "Antoine de Saint-Exupéry", 1943, 96, 2500);
			Konyv konyv2 = new ("Ez még készül", "Én");

            Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

			konyv1.Kedvezmeny(20);
			konyv1.Arnoveles(1000);

			Console.WriteLine("\n" + konyv1.ToString() + "\n" + konyv1.HanyoldalMaradt(20));

            Console.WriteLine();
            Film film1 = new ("Titanic", "James Cameron", 195, "romantikus", true);

			Film film2 = new ("Ez még készül", "Én");
			Console.WriteLine(film1.ToString());
            Console.WriteLine();
            film1.Jatszas();
            Console.WriteLine();
            film1.MufajModositas("");
			Console.WriteLine();
			film1.HosszNovelese(0);
		}
	}
}
