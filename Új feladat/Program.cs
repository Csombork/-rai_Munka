using Új_feladat;

Lista lista = new Lista();



for (int i = 0; i < 100; i++)
{
    lista.Hozzáadás(i);
    Console.WriteLine(lista.Kiír(i));
}