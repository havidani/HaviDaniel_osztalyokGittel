namespace oopgyakorlas
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
            Console.WriteLine();

            Karakter karakter1 = new Karakter("Gandalf", 10, 100, 20);
			Karakter karakter2 = new Karakter("Aragorn", 15, 150, 25);
			Console.WriteLine(karakter1.ToString());
			Console.WriteLine(karakter2.ToString());
			Console.WriteLine();
			karakter2.Tamadas();
			Console.WriteLine();
			karakter1.Gyogyulas(10);
			Console.WriteLine();
			karakter2.SzintLepes();
            Console.WriteLine();

			Urhajo urhajo1 = new Urhajo("Millennium Falcon", 1000, 10, 100);
			Urhajo urhajo2 = new Urhajo("X-Wing", 500, 2, 75);
			Console.WriteLine(urhajo1.ToString());
			Console.WriteLine(urhajo2.ToString());
            Console.WriteLine();
			urhajo1.Indulas();
            Console.WriteLine();
            urhajo2.Tankolas(10);
            Console.WriteLine();
            urhajo1.Landolas();
            Console.WriteLine();

			KemKuldetes kuldetes1 = new KemKuldetes("geza", "Magyarország", 10, 50);
			Console.WriteLine(kuldetes1.ToString());
			Console.WriteLine();
			kuldetes1.KuldetesInditasa();
			Console.WriteLine();
			kuldetes1.VeszelySzintNovelese(10);
			Console.WriteLine();
			kuldetes1.SikerEsejNovelese(5);
			Console.WriteLine();
		}
	}
}
