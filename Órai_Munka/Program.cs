Console.WriteLine("Írj be egy számot:");
int szam = int.Parse(Console.ReadLine());

int hossz = 0;

while (szam >= 1)
{
    szam /= 10;
    hossz++;
}

Console.WriteLine($"Ennyi karakterből áll a számod: {hossz}");