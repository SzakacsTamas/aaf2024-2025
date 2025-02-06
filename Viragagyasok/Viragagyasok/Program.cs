using viragAgyas;

List<adatok> viragok = new List<adatok>();
string[] sorok = File.ReadAllLines("felajanlas.txt");

//1.feladat



viragok = sorok.Skip(1).Select(sor => new adatok(sor)).ToList();//skippeli az első elemet majd kiválasztja a sor adatait majd minden adatból csinál egy példányt amit egy listába rak

for (int i = 0; i < viragok.Count; i++)
{
    viragok[i].sorSzam = i + 1;
}
//2.feladat
Console.WriteLine("2. feladat: A felajánlások száma {0}", viragok.Count);

//3.feladat
Console.WriteLine("3. feladat: A bejárat mindkét oldalán ültetők: ");
Console.WriteLine(String.Join(", ", viragok.Where(e => e.kapuBentVan).Select(e => e.sorSzam)));

//4.feladat
Console.WriteLine("4.feladat\nAdja meg a ");
int be = int.Parse(Console.ReadLine());
int darabok = 0;
string szin = "";
for (int i = 0; i < viragok.Count; i++)
{
    if (viragok[i].benneVanEz(be))
    {
        darabok++;
        if (szin == "")
        {
            Console.WriteLine();
        }
        szin = viragok[i].szin;

        
    }
}


Console.WriteLine("A felajánlások száma: {0}", darabok);

if(darabok == 0)
{
    Console.WriteLine("Ezt az ágyást nem ültették");
}
else
{

}