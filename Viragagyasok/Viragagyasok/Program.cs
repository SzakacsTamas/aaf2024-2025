
using Viragagyasok;
List<adatok> viragok = new List<adatok>();

string[] sorok = File.ReadAllLines("felajanlas.txt");


foreach (string s in sorok.Skip(1))
{
    viragok.Add(new adatok(s));
}

//2.fealadat
Console.WriteLine("2.feladat\n A felajánlások száma: {0}", viragok.Count);
//3.Feladat
Console.WriteLine("3.feladat\nA bejárat mindkét oldalán ültetők: ",);
//hagyományos

viragok =sorok.Skip(1).Select(sor => new adatok(sor)).ToList();
