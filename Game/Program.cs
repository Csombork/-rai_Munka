int pálya = 8;

int minhight = 10;
int minwidht = 40;

int hight = minhight + pálya;
int widht = minwidht + pálya;
int jh = minhight;
int jw = minwidht;

Console.CursorVisible = false;

Console.CursorLeft = minwidht;
Console.CursorTop = minhight;

for (int i = 0; i < pálya + 2; i++)
{
    Console.Write("\n");
    for (int j = 0; j < pálya + 2; j++)
    {
        if (i == 0 || i == pálya + 1 || j == 0 || j == pálya + 1)
        {

            Console.Write("#");
        }
        else
        {
            Console.Write(" ");
        }
    }
}


while (true) 
{ 
    Console.CursorLeft = jw;
    Console.CursorTop = jh;
    Console.Write("X");

    var beolvasott = Console.ReadKey(true);

    Console.CursorLeft = jw;
    Console.CursorTop = jh;
    Console.Write(" ");

    if (beolvasott.Key == ConsoleKey.S)
    {
        jh++;
    }
    if (beolvasott.Key == ConsoleKey.W)
    {
        jh--;
    }
    if (beolvasott.Key == ConsoleKey.A)
    {
        jw--;
    }
    if (beolvasott.Key == ConsoleKey.D)
    {
        jw++;
    }
    if (beolvasott.Key == ConsoleKey.S && jh > hight)
    {
        jh = minhight;
    }
    if (beolvasott.Key == ConsoleKey.W && jh < minhight)
    {
        jh = hight;
    }
    if (beolvasott.Key == ConsoleKey.A && jw < minwidht)
    {
        jw = widht;
    }
    if (beolvasott.Key == ConsoleKey.D && jw > widht)
    {
        jw = minwidht;
    }
}