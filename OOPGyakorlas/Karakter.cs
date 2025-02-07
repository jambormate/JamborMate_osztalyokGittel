using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyakorlas
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
			this.ero = ero;
			szint = 1;
			eletero = 1000;
		}

		public string Tamadas()
		{
			return $"{nev} támad {ero} erővel";
		}
		public void Gyogyulas(int mennyiseg)
		{
			eletero += mennyiseg;
		}
		public void Szintlepes()
		{
			szint += 1;
			ero += 5;
		}

		public override string? ToString()
		{
			return $"A karakter neve: {nev} szintje: {szint}, {eletero} életereje van és {ero} ereje";
		}
	}
}
