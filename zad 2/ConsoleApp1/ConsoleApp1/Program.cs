using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization; // dla parsowania liczb z przecinkiem/kropką

class Program
{
    static void Main()
    {
        string output = "ranking_clean.txt";
        string input = "ranking_raw.txt";
        if (!File.Exists(input))
        {
            return;
        }
        string[] linieTablica = File.ReadAllLines(input);
        //Tworzymy listę na linie (łatwiej modyfikować)
        List<string> linie = new List<string>(linieTablica);


        
        for (int i = 1; i < linie.Count; i++)
        {
            string linia = linie[i];

            // pomijamy puste linie
            if (string.IsNullOrWhiteSpace(linia)) continue;
            // Rozbijamy linię na 5 pól
            string[] pola = linia.Split(';');

            // Sprawdzenie, czy rzeczywiście jest 5 elementów
            if (pola.Length != 5)
            {
                Console.WriteLine($"Linia {i} ma złą liczbę pól: {linia}");
                continue;
            }
            string name = pola[0]; // nick
            string time = pola[1]; // czas
            string points = pola[2]; // punkty
            string statusText = pola[3]; // status
            string opisText = pola[4]; // opis
            bool badtime = (time == "00:00:01" || time == "0:00:01");
            bool statushacker = (statusText == "HACKER");
            if (badtime || statushacker)
            {
                linie.RemoveAt(i); 
                i--;   
                continue;
            }

            int point;
            if (!int.TryParse(points, out point))
            {
                point = 0;
            }
            

            string nowaLinia = name + ";" + time + ";" + point + ";" + statusText + ";" + opisText;
            // Nadpisujemy daną pozycję na liście
            linie[i] = nowaLinia;
        }

        // 4. Zapisujemy zmienione linie do pliku
        File.WriteAllLines(output, linie);

        // 5. Wyświetlamy nową zawartość pliku
        Console.WriteLine();
        string[] noweLinie = File.ReadAllLines(output);
        foreach (string l in noweLinie)
        {
            Console.WriteLine(l);
        }
    }
}