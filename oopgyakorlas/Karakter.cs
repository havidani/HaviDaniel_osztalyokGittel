using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopgyakorlas
{
	internal class Karakter
	{
		private string nev;
		private int szint;
		private int eletero;
		private int ero;

		public string Nev { get => nev; set => nev = value; }
		public int Szint { get => szint; set => szint = value; }
		public int Eletero { get => eletero; set => eletero = value; }
		public int Ero { get => ero; set => ero = value; }

		public Karakter(string nev, int szint, int eletero, int ero)
		{
			this.nev = nev;
			this.szint = szint;
			this.eletero = eletero;
			this.ero = ero;
		}

		public Karakter(string nev, int ero)
		{
			this.nev = nev;
			this.szint = 1;
			this.eletero = 100;
			this.ero = ero;
		}
		public void Tamadas()
		{
			Console.WriteLine($"{nev} támad, {ero} erővel.");
		}
		public void Gyogyulas(int mennyiseg)
		{
			eletero += mennyiseg;
			Console.WriteLine($"{nev} gyógyul {mennyiseg} életerővel. Jelenlegi életerő: {eletero}");

		}
		public void SzintLepes()
		{
			szint++;
			ero++;
			Console.WriteLine($"{nev} szintet lépett. Jelenlegi szint: {szint}. Jelenlegi erő: {ero}");
		}
		public override string ToString()
		{
			return $"{nev} - Szint: {szint}, Életerő: {eletero}, Erő: {ero}";
		}
	}
}
