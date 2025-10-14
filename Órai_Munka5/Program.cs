int width = 8; // A pálya adatai
int height = 8;

int row = 0; // A játékos adatai
int col = 0;

Console.CursorVisible = false;

Console.WriteLine("X");

Console.CursorLeft = 5;
Console.CursorTop = 5;

Console.Write("X");

var mitNyomottMeg = Console.ReadKey();

Console.WriteLine("\nEzt nyomtad meg:");
Console.WriteLine(mitNyomottMeg.Key);

if (mitNyomottMeg.Key == ConsoleKey.W)
{
    Console.WriteLine("WWWWW");
}

if (mitNyomottMeg.Key == ConsoleKey.L)
{
    Console.WriteLine("LLLLLLLL");
}