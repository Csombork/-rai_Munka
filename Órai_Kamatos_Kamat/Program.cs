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

if (nem == "férfi" || nem == "Férfi" || nem == "FÉRFI")
{
    nyughatár = 65 - év;
}
else
{
    nyughatár = 62 - év;
}

double kamat = 1.065;
Console.Write("\nMennyit fogsz fizetsz be havonta? ");
double havibefiz = double.Parse(Console.ReadLine());

for (int i = 0; i < nyughatár; i++)
{
    havibefiz *= kamat;
}

Console.WriteLine($"\nEnnyit tudnál a nyugdíjig megtakarítani: {havibefiz}");