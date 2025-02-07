namespace OOPGyakorlas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Konyv konyv1 = new("A Kis Herceg", "Antoine de Saint-Exupéry", 1943, 96, 2500);
			Konyv konyv2 = new("Ez még készül", "Én");

            Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

			konyv1.Kedvezmeny(20);
			konyv1.Arnoveles(1000);

			Console.WriteLine("\n" + konyv1.ToString() + "\n" + konyv1.HanyOldalMaradt(20));

			Film film1 = new("Tűzgyűrű", "Guillermo del Toro", 132, "sci-fi", true);
			Film film2 = new("Készülő film", "Én");
            
			Console.WriteLine(film1.ToString() + "\n" + film2.ToString());

			film1.MufajModositas("RomCom");
			film1.HosszNovelese(25);

            Console.WriteLine(film1.ToString() + "\n" + film1.Jatszas());

			Karakter karakter1 = new("Károly", 4, 175, 55);
			Karakter karakter2 = new("Sándor", 20);

			Console.WriteLine(karakter1.ToString() + "\n" + karakter2.ToString());

			karakter1.Gyogyulas(25);
			karakter1.Szintlepes();

			Console.WriteLine(karakter1.ToString() + "\n" + karakter1.Tamadas());

			Urhajo urhajo1 = new("Csillagpor", 120, 20, 60);
			Urhajo urhajo2 = new("Üstökös", 5);

			Console.WriteLine(urhajo1.ToString() + "\n" + urhajo2.ToString());

			urhajo2.Indulas();
			urhajo1.Tankolas(10);
			urhajo1.Landolas();

			Console.WriteLine(urhajo1.ToString() + "\n" + urhajo2.ToString());



		}

	}
}
