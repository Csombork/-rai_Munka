Console.Write("Adj meg egy számot: ");
int szam = int.Parse(Console.ReadLine());
Console.WriteLine("\nA szám osztói:");

bool prím = true;

for (int i = 2; i < szam; i++)
{
    if (szam % i == 0)
    {
        Console.WriteLine(i);
        prím = false;
    }
}

if (prím)
{
    Console.WriteLine("Ez egy prím szám!");
}
