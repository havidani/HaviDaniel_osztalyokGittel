using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopgyakorlas
{
	internal class Film
	{
		private string cim;
		private string rendezo;
		private int hosszPercekben;
		private string mufaj;
		private bool megjelent;

		public string Cim { get => cim; set => cim = value; }
		public string Rendezo { get => rendezo; set => rendezo = value; }
		public int HosszPercekben { get => hosszPercekben; set => hosszPercekben = value; }
		public string Mufaj { get => mufaj; set => mufaj = value; }
		public bool Megjelent { get => megjelent; set => megjelent = value; }

		public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelent)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			this.hosszPercekben = hosszPercekben;
			this.mufaj = mufaj;
			this.megjelent = megjelent;
		}

		public Film(string cim, string rendezo)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			hosszPercekben = 120;
			mufaj = "Ismeretlen";
			megjelent = false;
		}

		public void Jatszas()
		{
			Console.WriteLine($"\nA {cim} elkezdődött.");
		}
		public void MufajModositas(string ujMufaj)
		{
			Console.Write("Adja meg a módosított műfajt: ");
			ujMufaj = Console.ReadLine();
			mufaj = ujMufaj;
            Console.WriteLine($"\n{cim} - {rendezo} / {hosszPercekben} / {ujMufaj} - {megjelent}");
		}

		public void HosszNovelese(int percek)
		{
            Console.Write("Adja meg hány perccel szeretné növelni a film hosszát: ");
			percek = Convert.ToInt32(Console.ReadLine());
			hosszPercekben += percek;
			Console.WriteLine($"\n{cim} - {rendezo} / {hosszPercekben} / {mufaj} - {megjelent}");
        }

		public override string ToString()
		{
			return $"{cim} - {rendezo} / {hosszPercekben} / {mufaj} - {megjelent}";
		}
	}
}
