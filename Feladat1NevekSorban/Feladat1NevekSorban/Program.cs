StreamReader olvas = new StreamReader("nevek.txt");
while (!olvas.EndOfStream)
{
    
    string line = olvas.ReadLine();
    new string(line.OrderBy(c => c).ToArray());
    Console.WriteLine(line);
}