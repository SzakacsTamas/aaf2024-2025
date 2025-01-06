using System.Text.RegularExpressions;

string text = File.ReadAllText("generated_log_2024-12-11T11_21_39.997Z.txt");


Regex minta = new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");


var talalat = minta.Matches(text);
Console.WriteLine(talalat.Count);

