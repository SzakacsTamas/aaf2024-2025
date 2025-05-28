using VizibicikliKolcsonzoBeadando;
using System.Text;
using System.Collections.Generic;

List<adatok> kolcsonzes = new List<adatok>();
string[] sorok = File.ReadAllLines("kolcsonzesek.txt");

for (int i = 1; i < sorok.Length; i++)
{
    string[] adatok = sorok[i].Split(';');
    adatok adat = new adatok(adatok[0], adatok[1], Int32.Parse(adatok[2]), Int32.Parse(adatok[3]), Int32.Parse(adatok[4]), Int32.Parse(adatok[5]));
    kolcsonzes.Add(adat);
    
}
//Console.WriteLine(kolcsonzes[0].nev);ű

//5 Feladat
Console.WriteLine("5. Feladat: Napi kölcsönzések száma: "+kolcsonzes.Count());

//6 Feladat
Console.Write("Kérek egy nevet: ");
string bekertNev=Console.ReadLine();
bool kolcsonzottE=false;

foreach (adatok k in kolcsonzes)
{
    if (k.nev == bekertNev)
    {
        if (kolcsonzottE == false)
        {
            Console.WriteLine($"\t {bekertNev} kölcsönzései:");
            Console.WriteLine($"\t {k.elvitelOra:D2}:{k.elvitelPerc:D2} - {k.visszahozasOra:D2}:{k.visszahozasPerc:D2}");
            kolcsonzottE = true;
        }
        else
        {
            Console.WriteLine($"\t {k.elvitelOra:D2}:{k.elvitelPerc:D2} - {k.visszahozasOra:D2}:{k.visszahozasPerc:D2}");
        }
    }
    
}
if (kolcsonzottE == false)
{
    Console.WriteLine("Nem volt ilyen nevű kölcsönző!");
}

//7.Feladat
Console.Write("7. Feladat: Adjon meg egy időpontot óra:perc alakban:");
string[] idoBekeres=Console.ReadLine().Split(":");
int ora=int.Parse(idoBekeres[0]);
int perc=int.Parse(idoBekeres[1]);
int keresettIdopont=ora *60 +perc;
Console.WriteLine($"\tA vizen lévő járművek:");

foreach (adatok k in kolcsonzes)
{
    int elvitelPerc = k.elvitelOra * 60 + k.elvitelPerc;
    int visszahozatalPerc = k.visszahozasOra * 60 + k.visszahozasPerc;


    if (elvitelPerc <= keresettIdopont && keresettIdopont <= visszahozatalPerc)
    {
        Console.WriteLine($"\t{k.elvitelOra:D2}:{k.elvitelPerc:D2}-{k.visszahozasOra:D2}:{k.visszahozasPerc:D2} : {k.nev}");
    }
    
}

//8.Feladat

int osszesBevetel = 0;
const int arPerFelOra = 2400;

foreach(adatok k in kolcsonzes)
{
    int elvitel=k.elvitelOra*60+k.elvitelPerc;
    int visszahozatalPerc = k.visszahozasOra * 60 + k.visszahozasPerc;
    int ido=visszahozatalPerc-elvitel;

    int felorakSzama = (ido + 29) / 30;
    osszesBevetel += felorakSzama*arPerFelOra;

}

Console.WriteLine($"8.Feladat: A napi bevétel: {osszesBevetel} Ft");

//9.Feladat

List <string> FJarmuSorai = new List<string>();

foreach(adatok k in kolcsonzes)
{
    if (k.azonosito == "F")
    {
        string elvitelIdopontja = $"{k.elvitelOra:D2}:{k.elvitelPerc:D2}";
        string visszahozasIdopontja = $"{k.visszahozasOra:D2}:{k.visszahozasPerc:D2}";

        FJarmuSorai.Add($"{elvitelIdopontja}-{visszahozasIdopontja} : {k.nev}");
    }
}
File.WriteAllLines("F.txt", FJarmuSorai, Encoding.UTF8);

//10.Feladat

Console.WriteLine("10.Feladat: Statisztika");
Dictionary < string,int> statisztikaiAdatok = new Dictionary<string,int>();

foreach(adatok k in kolcsonzes)
{
    if (statisztikaiAdatok.ContainsKey(k.azonosito))
    {
        statisztikaiAdatok[k.azonosito]++;
    }
    else
    {
        statisztikaiAdatok [k.azonosito] = 1;
    }
}

List <string> betukABCRendben=statisztikaiAdatok.Keys.ToList();
betukABCRendben.Sort();

foreach(string adatok in betukABCRendben)
{
    Console.WriteLine($"\t {adatok} - {statisztikaiAdatok[adatok]}");
}