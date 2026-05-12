using System;

namespace KalkulatorRabatu
{
    // 1. Interfejs
    public interface IRabat
    {
        double Oblicz(double kwota);
    }

    // 2. Klasy implementujące interfejs
    public class BrakRabatu : IRabat
    {
        public double Oblicz(double kwota) => kwota;
    }

    public class RabatProcentowy : IRabat
    {
        public double Oblicz(double kwota) => kwota * 0.90; // Rabat 10%
    }

    public class RabatStaly : IRabat
    {
        public double Oblicz(double kwota)
        {
            double wynik = kwota - 20;
            return wynik < 0 ? 0 : wynik; // Zapewnienie, że cena nie spadnie poniżej 0
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double cenaWyjsciowa = PobierzCene();
            WyswietlMenu();
            int wybor = PobierzWybor();
            
            IRabat rabat = WybierzRabat(wybor);
            double cenaKoncowa = rabat.Oblicz(cenaWyjsciowa);

            WyswietlWynik(cenaKoncowa);
        }

        // 3. Metody pomocnicze
        static double PobierzCene()
        {
            while (true)
            {
                Console.Write("Podaj cenę produktu: ");
                if (double.TryParse(Console.ReadLine(), out double cena) && cena >= 0)
                    return cena;
                Console.WriteLine("Błąd! Podaj poprawną liczbę dodatnią.");
            }
        }

        static void WyswietlMenu()
        {
            Console.WriteLine("\nWybierz rodzaj rabatu:");
            Console.WriteLine("1 – brak rabatu");
            Console.WriteLine("2 – rabat 10%");
            Console.WriteLine("3 – rabat 20 zł");
        }

        static int PobierzWybor()
        {
            while (true)
            {
                Console.Write("Twój wybór: ");
                if (int.TryParse(Console.ReadLine(), out int wybor) && wybor >= 1 && wybor <= 3)
                    return wybor;
                Console.WriteLine("Błąd! Wybierz opcję od 1 do 3.");
            }
        }

        static IRabat WybierzRabat(int wybor)
        {
            return wybor switch
            {
                1 => new BrakRabatu(),
                2 => new RabatProcentowy(),
                3 => new RabatStaly(),
                _ => new BrakRabatu()
            };
        }

        static void WyswietlWynik(double wynik)
        {
            Console.WriteLine($"\nCena po zastosowaniu rabatu wynosi: {wynik:F2} zł");
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
