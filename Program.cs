namespace HasznaltAutoProjekt
{
    namespace HasznaltAutoProjekt
    {
        class Auto
        {
            public int Id;
            public string Marka;
            public string Modell;
            public int Evjarat;
            public int Ar;
            public int Kilometer;
            public string Uzemanyag;
            public int Teljesitmeny;

            public Auto(int id, string marka, string modell, int evjarat, int ar, int kilometer, string uzemanyag, int teljesitmeny)
            {
                Id = id;
                Marka = marka;
                Modell = modell;
                Evjarat = evjarat;
                Ar = ar;
                Kilometer = kilometer;
                Uzemanyag = uzemanyag;
                Teljesitmeny = teljesitmeny;
            }

            public override string ToString()
            {
                return Id + ". " + Marka + " " + Modell +
                       " | Évjárat: " + Evjarat +
                       " | Ár: " + Ar + " Ft" +
                       " | Kilométer: " + Kilometer + " km" +
                       " | Üzemanyag: " + Uzemanyag +
                       " | Teljesítmény: " + Teljesitmeny + " LE";
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<Auto> autok = new List<Auto>();

                string[] sorok = File.ReadAllLines("autok.txt");

                for (int i = 1; i < sorok.Length; i++)
                {
                    string[] adatok = sorok[i].Split(';');

                    Auto auto = new Auto(
                        Convert.ToInt32(adatok[0]),
                        adatok[1],
                        adatok[2],
                        Convert.ToInt32(adatok[3]),
                        Convert.ToInt32(adatok[4]),
                        Convert.ToInt32(adatok[5]),
                        adatok[6],
                        Convert.ToInt32(adatok[7])
                    );

                    autok.Add(auto);
                }

                Console.WriteLine("HASZNÁLT AUTÓ KERESKEDÉS");
                Console.WriteLine("========================");
                Console.WriteLine();

                Console.WriteLine("Az autók adatai:");
                Console.WriteLine();

                for (int i = 0; i < autok.Count; i++)
                {
                    Console.WriteLine(autok[i]);
                }

                Console.WriteLine();
                Console.WriteLine("========================");

                // Legolcsóbb autó
                Auto legolcsobb = autok[0];

                for (int i = 1; i < autok.Count; i++)
                {
                    if (autok[i].Ar < legolcsobb.Ar)
                    {
                        legolcsobb = autok[i];
                    }
                }

                Console.WriteLine("Legolcsóbb autó:");
                Console.WriteLine(legolcsobb);
                Console.WriteLine();

                // Legdrágább autó
                Auto legdragabb = autok[0];

                for (int i = 1; i < autok.Count; i++)
                {
                    if (autok[i].Ar > legdragabb.Ar)
                    {
                        legdragabb = autok[i];
                    }
                }

                Console.WriteLine("Legdrágább autó:");
                Console.WriteLine(legdragabb);
                Console.WriteLine();

                // Legkevesebbet futott autó
                Auto legkevesebbetFutott = autok[0];

                for (int i = 1; i < autok.Count; i++)
                {
                    if (autok[i].Kilometer < legkevesebbetFutott.Kilometer)
                    {
                        legkevesebbetFutott = autok[i];
                    }
                }

                Console.WriteLine("Legkevesebbet futott autó:");
                Console.WriteLine(legkevesebbetFutott);
                Console.WriteLine();

                // Átlagár
                int osszeg = 0;

                for (int i = 0; i < autok.Count; i++)
                {
                    osszeg = osszeg + autok[i].Ar;
                }

                double atlagAr = (double)osszeg / autok.Count;

                Console.WriteLine("Az autók átlagára: " + atlagAr + " Ft");
                Console.WriteLine();

                // Benzines autók
                Console.WriteLine("Benzines autók:");

                for (int i = 0; i < autok.Count; i++)
                {
                    if (autok[i].Uzemanyag == "Benzin")
                    {
                        Console.WriteLine(autok[i]);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("A program véget ért.");
                Console.ReadKey();
            }
        }
    }
}