string name = "Szlány Csombor";
int year = 11;
char code = 'K';
bool tech = true;

// Lehet így is rövidíteni
Student egyik = new (name, year, code, tech);


// Technikailag így is lehet
var masik = new Student(name, year, code, tech);

if (egyik == masik)
{
    Console.WriteLine("Ezek egyeznek!!!");
}

if (egyik != masik)
{
    Console.WriteLine("Ezek nem egyeznek...");
}

Console.WriteLine("Egyik\n" + egyik);
Console.WriteLine("Másik\n" + masik);

record class Student(string Name, int year, char code, bool tech);