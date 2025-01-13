using belepteto;


List<adatok> esemenyek = new List<adatok>();
string[] sorok = File.ReadAllLines("bedat.txt");

for (int i = 0; i < sorok.Length; i++)
{
    esemenyek.Add(new adatok(sorok[i]));
}

Console.WriteLine("2.feladat");
Console.WriteLine("Az első tanuló {0}-kor lépett be a főkapun.", esemenyek[0].ido);
Console.WriteLine("Az utolsó tanuló {0}-kor lépett ki a főkapun.", esemenyek[esemenyek.Count - 1].ido);

Console.WriteLine("3.feladat");

StreamWriter ir = new StreamWriter("kesok.txt");
for (int i = 0; i < esemenyek.Count; i++)
{
    if (((esemenyek[i].ora == 7 && esemenyek[i].perc >= 50) || (esemenyek[i].ora == 8 && esemenyek[i].perc <= 15)) && esemenyek[i].esemeny == 1)
    {
        ir.WriteLine(esemenyek[i].ido + " " + esemenyek[i].kod);
    }
}
ir.Close();

Console.WriteLine("4.feladat");
int darab = 0;
for (int i = 0; i < esemenyek.Count; i++)
{
    if (esemenyek[i].esemeny == 3)
    {
        darab++;
    }
}
Console.WriteLine($"A menzán aznap {darab} tanuló ebédelt.");

Console.WriteLine("5.feladat");

HashSet<string> konyvtar = new HashSet<string>();
for (int i = 0; i < esemenyek.Count; i++)
{
    if (esemenyek[i].esemeny == 4)
    {
        konyvtar.Add(esemenyek[i].kod);
    }

}
if (konyvtar.Count > darab)
{
    Console.WriteLine("Többen voltak,mint a menzán.");
}
else
{
    Console.WriteLine("Nem voltak többet a menzán.");
}

//feladat6
HashSet<string> kodok= new HashSet<string>();
for (int i = 0;i < esemenyek.Count; i++)
{
    kodok.Add(esemenyek[i].kod);

}
foreach (string egykod in kodok)
{
    bool bentVan = false;
    for (int i = 0; i < esemenyek.Count; i++)
    {
        if (esemenyek[i].kod == egykod)
        {
            if (esemenyek[i].esemeny == 1)
            {
                if (bentVan) 
                {
                    if (esemenyek[i].ora==10 && esemenyek[i].perc)
                }
                else
                {
                    bentVan= true;
                }
            }
           

        }

    }
    //Console.WriteLine(egykod);
}