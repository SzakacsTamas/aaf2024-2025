
string szam = Console.ReadLine();

StreamWriter fajl = new StreamWriter("adatok.txt");
while (szam != "0")
{
    szam = Console.ReadLine();
    
    fajl.WriteLine(szam+ szam * szam"");
    fajl.WriteLine();

}

fajl.Close();