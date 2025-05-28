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


StreamWriter mondatok= new StreamWriter("mondatok.txt");
Random random = new Random();
for (int i = 0; i < alanyok.Count; i++)
{
    int elso= random.Next(jelzok.Count);
    int masodik = random.Next(alanyok.Count);
    int harmadik = random.Next(igek.Count);
    int negyedik = random.Next(helyek.Count);
    mondatok.WriteLine("A(z) " + jelzok[elso] +" "+ alanyok[masodik]+" "+ igek[harmadik]+" " + helyek[negyedik]+".");

}
mondatok.Close();
alany.Close();