using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

string szoveg = File.ReadAllText("adatok.txt");

//1 FELADAT
Regex minta = new Regex(@"POST .+\d{3} (\d+) ");


var talalat = minta.Matches(szoveg);

int osszesPost = 0;


foreach (Match elem in talalat)
{
    osszesPost += Convert.ToInt32(elem.Groups[1].Value);
}
Console.WriteLine("Az összes Post-ra érkezett adatmennyiség: " + osszesPost);

//2 FELADAT
Regex minta2 = new Regex(@"DELETE");
var talalat2 = minta2.Matches(szoveg);

Console.WriteLine("Ennyi törlés történt: "+talalat2.Count);


//3 FELADAT
/*
Regex minta3= new Regex(@"https://www\.\S);
var talalat3=minta3.Matches(szoveg);
*/
//4 FELADAT
Regex minta4 = new Regex(@"""\S+ (/\S+) .+"" \d+ \d+ ""-""");
var talalat4 = minta4.Matches(szoveg);

StreamWriter ir = new StreamWriter("noreferer.log");

foreach (Match match in talalat4)
{
    ir.WriteLine(match.Groups[1]);
}


ir.Close();