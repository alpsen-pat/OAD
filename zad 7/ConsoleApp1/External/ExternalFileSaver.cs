using System;

namespace ConsoleApp1.External;

public class ExternalFileSaver
{
    public void SaveToFileSystem(string textData)
    {
        Console.WriteLine("[ExternalFileSaver] Zapisywanie danych do systemu plików...");
        Console.WriteLine(textData);
        Console.WriteLine("[ExternalFileSaver] Zapisano pomyślnie.\n");
    }
}