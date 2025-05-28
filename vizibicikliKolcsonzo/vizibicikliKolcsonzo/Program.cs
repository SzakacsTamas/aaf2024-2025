using System.Text;
using vizibicikliKolcsonzo;


List<adatok> kolcsonzes = new List<adatok>();
string[] sorok = File.ReadAllLines("kolcsonzesek.txt");
for (int i = 1; i < sorok.Length; i++)
{
    string[] vag = sorok[i].Split(";");
    kolcsonzes.Add(new adatok(vag[0], vag[1], Convert.ToInt32(vag[2]), Convert.ToInt32(vag[3]), Convert.ToInt32(vag[4]), Convert.ToInt32(vag[5])));
}
//5. Feladat
Console.WriteLine("5.Feladat: Napi kölcsönzések száma: " + kolcsonzes.Count());

//6. Feladat
Console.Write("6.Feladat: Kérek egy nevet: ");
string bekertNev=Console.ReadLine();
bool kolcsonzottE=false;
foreach (adatok k in kolcsonzes)
{
    if (k.nev == bekertNev)
    {
        if (kolcsonzottE == false)
        {
            Console.WriteLine($"\t{bekertNev} kölcsönzései:");
            Console.WriteLine($"\t{k.elvitelOra:D2}:{k.elvitelPerc:D2}-{k.visszahozatalOra:D2}:{k.visszahozatalPerc:D2}");
            kolcsonzottE = true;
        }
        else
        {
            Console.WriteLine($"\t{k.elvitelOra:D2}:{k.elvitelPerc:D2}-{k.visszahozatalOra:D2}:{k.visszahozatalPerc:D2}");
        }
    }
}
if (kolcsonzottE == false)
{
    Console.WriteLine("Nem volt ilyen nevű kölcsönző!");
}
// 7. Feladat
Console.Write("7. Feladat: Adjon meg egy időpontot óra:perc alakban: ");
string[] idopontBekeres = Console.ReadLine().Split(':');
int ora = int.Parse(idopontBekeres[0]);
int perc = int.Parse(idopontBekeres[1]);

int keresettPerc = ora * 60 + perc;

Console.WriteLine($"\tA vízen lévő járművek:");

foreach (adatok k in kolcsonzes)
{
    int elvitelPerc = k.elvitelOra * 60 + k.elvitelPerc;
    int visszahozatalPerc = k.visszahozatalOra * 60 + k.visszahozatalPerc;

    if (elvitelPerc <= keresettPerc && keresettPerc <= visszahozatalPerc)
    {
        Console.WriteLine($"\t{k.elvitelOra:D2}:{k.elvitelPerc:D2}-{k.visszahozatalOra:D2}:{k.visszahozatalPerc:D2} : {k.nev}");
    }
}

// 8. Feladat
int osszBevetel = 0;
const int arPerFelora = 2400;

foreach (adatok k in kolcsonzes)
{
    int elvitel = k.elvitelOra * 60 + k.elvitelPerc;
    int vissza = k.visszahozatalOra * 60 + k.visszahozatalPerc;
    int ido = vissza - elvitel;

    int felorakSzama = (ido + 29) / 30; // minden megkezdett félóra számít
    osszBevetel += felorakSzama * arPerFelora;
}

Console.WriteLine($"8. Feladat: A napi bevétel: {osszBevetel} Ft");

// 9. Feladat
List<string> fJarmuSorok = new List<string>();


foreach (adatok k in kolcsonzes)
{
    if (k.azonosito == "F")
    {
        string elvitel = $"{k.elvitelOra:D2}:{k.elvitelPerc:D2}";
        string vissza = $"{k.visszahozatalOra:D2}:{k.visszahozatalPerc:D2}";
        fJarmuSorok.Add($"{elvitel}-{vissza} : {k.nev}");
    }
}

File.WriteAllLines("F.txt", fJarmuSorok, Encoding.UTF8);


// 10. Feladat
Console.WriteLine("10. feladat: Statisztika");

Dictionary<string, int> statisztika = new Dictionary<string, int>();

foreach (adatok k in kolcsonzes)
{
    if (statisztika.ContainsKey(k.azonosito))
    {
        statisztika[k.azonosito]++;
    }
    else
    {
        statisztika[k.azonosito] = 1;
    }
}

// Ábécérendbe rendezett kulcsok kiírása
List<string> kulcsok = statisztika.Keys.ToList();
kulcsok.Sort();

foreach (string kulcs in kulcsok)
{
    Console.WriteLine($"\t{kulcs} - {statisztika[kulcs]}");
}
