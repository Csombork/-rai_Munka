/*int kamatszázal = 1;

Console.Write("Írd be mennyit akarsz befektetni: ");
double befektetett = double.Parse(Console.ReadLine());
Console.Write("\nHány hétre szeretnéd? ");
int hetek = int.Parse(Console.ReadLine());

double kamat;

for (int i = 0; i < hetek; i++)
{
    kamat = befektetett / 100 * kamatszázal;
    befektetett += kamat;
}

Console.WriteLine($"\nEnnyi pénzed lesz a végén: {befektetett}");
*/

/*double egyenleg = 1000;
double plafon = 1_000_000_000;
double kamat = 1.2;
int évek = 0;

do
{
    egyenleg *= kamat;
    évek++;
}
while (egyenleg < plafon);

Console.WriteLine($"Ennyi évre kéne befektetni: {évek}\nHogy ennyi pénzed legyen: {egyenleg}");*/

Console.Write("Hány éves vagy? ");
int év = int.Parse(Console.ReadLine());
Console.Write("\nFérfi vagy vagy nő? ");
string nem = Console.ReadLine();
int nyughatár;

if (nem == "férfi" || nem == "Férfi" || nem == "FÉRFI" || nem == "ferfi" || nem == "Ferfi" || nem == "FERFI")
{
    nyughatár = 65 - év;
}
else if (nem == "nő" || nem == "Nő" || nem == "NŐ" || nem == "no" || nem == "No" || nem == "NO")
{
    nyughatár = 62 - év;
}
else
{
    nyughatár = 0;
    Console.WriteLine("\nSorry, but így nyem fog műlködni :|");
}

double kamat = 1.065;
Console.Write("\nMennyit fogsz befizetni havonta? ");
double havibefiz = double.Parse(Console.ReadLine());
double összeg = 0;

for (int i = 0; i < nyughatár; i++)
{
    összeg += havibefiz * 12;
    if (havibefiz * 12 * 0.2 <= 130_000)
    {
        összeg += havibefiz * 12 * 0.2;
    }
    else
    {
        összeg += 130_000;
    }
    összeg *= kamat;
}

Console.WriteLine($"\nEnnyit tudnál a nyugdíjig megtakarítani: {összeg}Ft");
Console.WriteLine($"Ez összesen havonta kb {összeg / (12*20)}Ft lesz.");