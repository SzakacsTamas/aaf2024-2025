

static int fakt(int szam) 
{
    int eredmeny = 1;
   
    if (szam > 1)
    {
        int eredmeny = fakt(szam - 1);
    }
    else
    {
        return 1;
    }
    
    return szam;
}
Console.WriteLine(fakt(5);