using System.Net;

Random random = new Random();

int RandomSzamjegy()
{
    return RandomSzam(0,9);
}

int RandomSzam(int min, int max)
{
    int szam = random.Next(min, max + 1);
    return szam;
}

int VéletlenSzázalék()
{
    int veletlen = random.Next(0, 101);
    return veletlen;
}

int KockaDobás()
{
    int randobás = RandomSzam(1, 6);
    return randobás;
}

bool Pénzérme()
{
    int szam = random.Next(0, 2);
    if (szam == 0)
    {
        return true;
    }
    return false;
}

char RandBetű()
{
    int hanyadik = random.Next(97, 97 + 26);
    return (char) hanyadik;
}

char RandKisBetű()
{
    char betű = RandBetű();
    return char.ToLower(betű);
}

char RandNagyBetű()
{
    char betű = RandBetű();
    return char.ToUpper(betű);
}

char RandKisNagyBetű()
{
    int rand = random.Next(0,2);
    if (rand == 0)
    {
        return RandKisBetű();
    }
    return RandNagyBetű();
}

string RandSzöv(int hossz)
{
    string szöveg = string.Empty;
    szöveg += RandNagyBetű();
    for (int i = 0; i < hossz - 1; i++)
    {
        szöveg += RandKisBetű();
    }
    return szöveg;
}

string RandJelsz(int hossz)
{
    string szöveg = string.Empty;
    szöveg += RandNagyBetű();
    for (int i = 0; i < hossz - 1; i++)
    {
        int szaz = VéletlenSzázalék();
        if (szaz <= 40)
        {
            szöveg += RandomSzamjegy();
        }
        else
        {
            szöveg += RandKisNagyBetű();
        }
    }
    return szöveg;
}

Console.WriteLine(RandJelsz(12));