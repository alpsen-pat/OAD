using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization; // dla parsowania liczb z przecinkiem/kropką

class Program
{
    static void Main()
    {
        string sciezka = "ranking_clean.txt";
        if (!File.Exists(sciezka))
        {
            return;
        }
        string[] linieTablica = File.ReadAllLines(sciezka);
        //Tworzymy listę na linie (łatwiej modyfikować)
        List<string> linie = new List<string>(linieTablica);


        foreach (string l in linie)
        {
            Console.WriteLine(l);
        }
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

            // Parsowanie liczb

            int ilosc = int.Parse(points);


            string nowaLinia = name + ";" + time + ";" + ilosc + ";" + statusText + ";" + opisText;
            // Nadpisujemy daną pozycję na liście
            linie[i] = nowaLinia;
        }
    }
}