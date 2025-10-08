for (int i = 1; i <= 9; i++)
{
    Console.WriteLine();
    for (int j = 1;j <= 9;j++)
    {
        if ((i * j) / 10 == 0)
        {
            Console.Write(i * j + "  ");
        }
        else
        {
            Console.Write(i * j + " ");
        }
    }
}