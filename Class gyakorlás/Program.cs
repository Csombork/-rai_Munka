Random r = new Random();

for (int i = 0; i < 100; i++) // 100 hármszög generálása
{
    while (true)
    {
        int a = r.Next(1, 101);
        int b = r.Next(1, 101);
        int c = r.Next(1, 101);
        var haromszog = new Haromszog(a, b, c);
        if (haromszog.Szerkesztheto())
        {
            break;
        }
    }

}