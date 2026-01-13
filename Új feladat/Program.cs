using Új_feladat;

Lista lista = new Lista();
Lista szöveg = new Lista();
List<int> list = [];

list.Add(58);


int[] tomb = [1, 2, 3, 4];

lista.Hozzáadás(tomb);

for (int i = 0; i < 100; i++)
{
    lista.Hozzáadás(i);
    Console.WriteLine(lista.Kiír(i));
}

Console.WriteLine("Összeg");
Console.WriteLine(lista.Osszeg());
Console.WriteLine();

Console.WriteLine("Hibás");
Console.WriteLine(lista.Tartalmaz(123456));
Console.WriteLine(lista.Index(123456));

Console.WriteLine("\nHelyes");
Console.WriteLine(lista.Tartalmaz(10));
Console.WriteLine(lista.Index(10));




