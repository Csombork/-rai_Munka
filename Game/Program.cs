int pálya = 8;

int minheight = 10;
int minwidht = 40;

int maxheight = minheight + pálya;
int maxwidth = minwidht + pálya;
int jh = minheight;
int jw = minwidht;

Console.CursorVisible = false;

Console.CursorTop = minheight;
Console.CursorLeft = minwidht;

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
    if (beolvasott.Key == ConsoleKey.S && jh > maxheight)
    {
        jh = minheight;
    }
    if (beolvasott.Key == ConsoleKey.W && jh < minheight)
    {
        jh = maxheight;
    }
    if (beolvasott.Key == ConsoleKey.A && jw < minwidht)
    {
        jw = maxwidth;
    }
    if (beolvasott.Key == ConsoleKey.D && jw > maxwidth)
    {
        jw = minwidht;
    }
}