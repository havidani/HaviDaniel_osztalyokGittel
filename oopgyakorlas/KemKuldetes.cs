using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopgyakorlas
{
	internal class KemKuldetes
	{
		private string kodnev;
		private string orszag;
		private int veszelySzint;
		private int sikerEsej;

		public string Kodnev { get => kodnev; set => kodnev = value; }
		public string Orszag { get => orszag; set => orszag = value; }
		public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
		public int SikerEsej { get => sikerEsej; set => sikerEsej = value; }

		public KemKuldetes(string kodnev, string orszag, int veszelySzint, int sikerEsej)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			this.veszelySzint = veszelySzint;
			this.sikerEsej = sikerEsej;
		}

		public KemKuldetes(string kodnev, string orszag)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			this.veszelySzint = 5;
			this.sikerEsej = 50;
		}
		public void KuldetesInditasa()
		{
			Console.WriteLine("A küldetés elkezdődött.");
		}
		public void VeszelySzintNovelese(int mennyiseg)
		{
			veszelySzint += mennyiseg;
			Console.WriteLine($"Jelenlegi veszélyszint: {veszelySzint}");

		}
		public void SikerEsejNovelese(int szazalek)
		{
			sikerEsej += szazalek;
			Console.WriteLine($"Jelenlegi sikeresély: {sikerEsej}");
		}
		public override string ToString()
		{
			return $"{kodnev} - Ország: {orszag}, Veszélyszint: {veszelySzint}, Sikeresély: {sikerEsej}";
		}
	}
}
