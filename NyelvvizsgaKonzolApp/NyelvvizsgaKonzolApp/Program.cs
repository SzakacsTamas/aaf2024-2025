using NyelvvizsgaKonzolApp;
List<NyelvAdat> sikeres = new List<NyelvAdat>();
List<NyelvAdat> sikertelen = new List<NyelvAdat>();

static List<NyelvAdat> fajlBe(string fajlnev)
{
    List<NyelvAdat> adatok = new List<NyelvAdat>();
    StreamReader olvas = new StreamReader(fajlnev);
    
    while (!olvas.EndOfStream)
    {
        adatok.Add(new NyelvAdat(olvas.ReadLine(),evek));
    }
    olvas.Close();
    return adatok;
}
fajlBe("sikeres.csv");