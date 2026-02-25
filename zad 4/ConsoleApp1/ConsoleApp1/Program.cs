using System;

class Gracz
{
    public string Imie;
    public int Punkty;
}

class Program
{
    static void Main()
    {
        Gracz[] gracze = {
            new Gracz { Imie = "Kuba", Punkty = 12 },
            new Gracz { Imie = "Ola", Punkty = 25 },
            new Gracz { Imie = "Bartek", Punkty = 8 },
            new Gracz { Imie = "Ania", Punkty = 19 },
            new Gracz { Imie = "Mati", Punkty = 30 }
        };

        int porownania = 0;
        int zamiany = 0;

        Console.WriteLine("PRZED SORTOWANIEM:");
        WypiszRanking(gracze);

        // SORTOWANIE BĄBELKOWE (malejąco po punktach)
        for (int i = 0; i < gracze.Length - 1; i++)
        {
            for (int j = 0; j < gracze.Length - 1 - i; j++)
            {
                porownania++; // TODO 1: zwiększ licznik porównań
                
                // TODO 2: jeśli gracze[j].Punkty < gracze[j + 1].Punkty
                // to zamień całe obiekty miejscami i zwiększ licznik zamian
                if (gracze[j].Punkty < gracze[j + 1].Punkty)
                {
                    Gracz temp = gracze[j];
                    gracze[j] = gracze[j + 1];
                    gracze[j + 1] = temp;
                    zamiany++;
                }
            }

            // TODO 3 (na 4+): wypisz ranking po każdym przebiegu
            Console.WriteLine($"\nRanking po kroku {i + 1}:");
            WypiszRanking(gracze);
        }

        Console.WriteLine("\nPO SORTOWANIU:");
        WypiszRanking(gracze);

        // TODO 4 (na 4+): wypisz TOP 3
        Console.WriteLine("\n--- TOP 3 ---");
        for (int i = 0; i < Math.Min(3, gracze.Length); i++)
        {
            Console.WriteLine($"{i + 1}. {gracze[i].Imie} - {gracze[i].Punkty} pkt");
        }
        // TODO 5 (na 5): wypisz porównania i zamiany
        Console.WriteLine($"\nStatystyki algorytmu:");
        Console.WriteLine($"Liczba porównań: {porownania}");
        Console.WriteLine($"Liczba zamian: {zamiany}");
    }

    static void WypiszRanking(Gracz[] gracze)
    {
        for (int i = 0; i < gracze.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {gracze[i].Imie} - {gracze[i].Punkty} pkt");
        }
    }
}