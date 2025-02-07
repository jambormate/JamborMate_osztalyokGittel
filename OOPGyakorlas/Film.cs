using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyakorlas
{
	internal class Film
	{
		private string cim;
		private string rendezo;
		private int hosszPercekben;
		private string mufaj;
		private bool megjelent;

		public Film(string cim, string rendezo)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			hosszPercekben = 120;
			mufaj = "Ismeretlen";
			megjelent = false;
		}

		public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelent)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			this.hosszPercekben = hosszPercekben;
			this.mufaj = mufaj;
			this.megjelent = megjelent;
		}

		public string Cim { get => cim; set => cim = value; }
		public string Rendezo { get => rendezo; set => rendezo = value; }
		public int HosszPercekben { get => hosszPercekben; set => hosszPercekben = value; }
		public string Mufaj { get => mufaj; set => mufaj = value; }
		public bool Megjelent { get => megjelent; set => megjelent = value; }


		public void HosszNovelese(int percek)
		{
			hosszPercekben += percek;
		}

		public string Jatszas()
		{
			return $"{cim} elindult";
		}

		public void MufajModositas(string ujMufaj)
		{
			mufaj = ujMufaj;
		}
		public override string? ToString()
		{
			return $"{cim} - {rendezo} / {hosszPercekben} / {mufaj} / {megjelent}";
		}
	}
}
