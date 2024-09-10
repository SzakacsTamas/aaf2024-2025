StreamReader alany = new StreamReader("alany.txt");
StreamReader hely = new StreamReader("hely.txt");
StreamReader ige = new StreamReader("ige.txt");
StreamReader jelzo = new StreamReader("jelzo.txt");

List<string> alanyok= new List<string>();
List<string> helyek = new List<string>();
List<string> igek = new List<string>();
List<string> jelzok = new List<string>();

while (!alany.EndOfStream)
{
    alanyok.Add(alany.ReadLine());
    helyek.Add(hely.ReadLine());
    igek.Add(ige.ReadLine());
    jelzok.Add(jelzo.ReadLine());

    
}
foreach (string s in jelzok)
    { Console.WriteLine(s); }

Random random = new Random();
for (int i = 0; i < alanyok.Count; i++)
{
    int elso= random.Next(jelzok.Count);
    int masodik = random.Next(alanyok.Count);
    int harmadik = random.Next(igek.Count);
    int negyedik = random.Next(helyek.Count);
    Console.WriteLine("A(Az) " + jelzok[elso] +" "+ alanyok[masodik]+" "+ igek[harmadik]+" " + helyek[negyedik]+".");

}

alany.Close();