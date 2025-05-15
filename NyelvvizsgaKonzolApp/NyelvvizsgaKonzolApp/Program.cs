using NyelvvizsgaKonzolApp;
List<NyelvAdat> sikeres = new List<NyelvAdat>();
List<NyelvAdat> sikertelen = new List<NyelvAdat>();

static List<NyelvAdat> fajlBe(string fajlnev)
{
    List<NyelvAdat> adatok = new List<NyelvAdat>();
    StreamReader olvas = new StreamReader(fajlnev);
    string elsoSor = olvas.ReadLine();
    string[] vag = elsoSor.Split(";");
    int[] evek = new int[vag.Length - 1];
    for (int i = 1; i < vag.Length; i++)
    {
        evek[i - 1] = int.Parse(vag[i]);
    }
    while (!olvas.EndOfStream)
    {
        adatok.Add(new NyelvAdat(olvas.ReadLine(),evek));
    }
    olvas.Close();
    return adatok;
}
fajlBe("sikeres.csv");