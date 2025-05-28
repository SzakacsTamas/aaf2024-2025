using Morze;

List<adatok> morze = new List<adatok>();

string[] sorok = File.ReadAllLines("morzeabc.txt");
for (int i = 1; i < sorok.Length; i++)
{
    string[] vag = sorok[i].Split("\t");
    morze.Add(new adatok(vag[0], vag[1]));
}

Console.WriteLine("3.Feladat: A morze abc "+morze.Count()+" db karakter kódját tartalmazza.");

Console.Write("4.Feladat: Kérek egy karaktert: ");

string bekeres=Console.ReadLine();
var be = morze.Where(x => x.betu == bekeres).FirstOrDefault();


if (be!=null)
{
    Console.WriteLine("\tA "+ bekeres+" karakter morze kódja: "+be.kod);
}
else
{
    Console.WriteLine("Nem található a kódtárban ilyen karakter!");
}

