using System.Runtime.InteropServices.JavaScript;

int hight = 8;
int widht = 8;
int jh = 0;
int jw = 0;

Console.CursorVisible = false;

while (true)
{
    var beolvasott = Console.ReadKey();
    Console.Clear();

    if (beolvasott.Key == ConsoleKey.S && jh < Console.WindowHeight - 1)
    {
        jh++;
    }
    if (beolvasott.Key == ConsoleKey.W && jh > 0)
    {
        jh--;
    }
    if (beolvasott.Key == ConsoleKey.A && jw > 0)
    {
        jw--;
    }
    if (beolvasott.Key == ConsoleKey.D && jw < Console.WindowWidth - 1)
    {
        jw++;
    }
    Console.CursorLeft = jw;
    Console.CursorTop = jh;
    Console.WriteLine("X");
}