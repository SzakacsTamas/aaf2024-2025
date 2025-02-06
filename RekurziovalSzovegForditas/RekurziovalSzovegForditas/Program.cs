using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kérem, adja meg a szöveget:");
        string input = Console.ReadLine();  // Bekérjük a felhasználótól a szöveget

        string reversed = ReverseString(input);  // Meghívjuk a rekurzív függvényt
        Console.WriteLine("A szöveg fordítva: " + reversed);
    }

    // Rekurzív függvény a szöveg megfordításához
    static string ReverseString(string str)
    {
        if (str.Length == 0)  // Alap eset: ha a szöveg üres, akkor visszaadjuk az üres szöveget
            return str;

        // Rekurzívan hívjuk a függvényt a szöveg többi részére, majd hozzáadjuk az első karaktert
        return ReverseString(str.Substring(1)) + str[0];
    }
}
