Console.Write("Írj be egy egész számot, ami 8 jegyű lesz és egy TAJ számot jelöl:");
int TAJ = int.Parse(Console.ReadLine());
Console.WriteLine();
int utsószámjegy = TAJ % 10;
TAJ = TAJ / 10;
int összeg = 0;

for (int i = 1; i < 9; i++)
{
    int számjegy = TAJ % 10;
    
    if (i % 2 == 0)
    {
        számjegy *= 3;
    }
    else
    {
        számjegy *= 7;
    }
    összeg += számjegy;
    TAJ = TAJ / 10;
}

if (összeg % 10 == TAJ)
{
    Console.WriteLine("Ez egy valid TAJ szám!");
}
else
{
    Console.WriteLine("Érvénytelen TAJ szám!");
}

Console.WriteLine(összeg);
Console.WriteLine(TAJ);