Console.Write("Adj meg egy számot: ");
int szam = int.Parse(Console.ReadLine());
Console.WriteLine("\nA szám osztói:");

bool prím = true;
string osztói = "";

for (int i = 2; i < szam; i++)
{
    if (szam % i == 0)
    {
        prím = false;
        osztói += i + " ";
    }
}

if (prím)
{
    Console.WriteLine("Ez egy prím szám!");
}
else
{
    Console.WriteLine(osztói);
}
