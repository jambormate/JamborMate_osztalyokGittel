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
        }	
	}
}
