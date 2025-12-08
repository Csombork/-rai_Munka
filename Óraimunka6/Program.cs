Random veletlen = new Random();

int RandomSzam(int minimum = 0, int maximum = int.MaxValue)
{
    int szam = veletlen.Next(minimum, maximum + 1);
    return szam;
}


int Számjegy()
{
    int szam = veletlen.Next(1, 10);
    return szam;
}

int Százalék()
{
    int szam = veletlen.Next(0,101);
    return szam;
}

bool Pénzérme()
{
    int szam = veletlen.Next(0,2);
    if (szam == 0)
    {
        return true;
    }

    return false;
}

Console.WriteLine(Pénzérme());