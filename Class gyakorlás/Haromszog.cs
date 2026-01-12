internal class Haromszog
{
    private int a;
    private int b;
    private int c;

    public Haromszog(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public bool Szerkesztheto()
    {
        if ((a + b > c) && (a + c > b) && (b + c > a))
        {
            return true;
        }
        return false;
    }

    public int Kerulet()
    {
        int k = a + b + c;
        return k;
    }

    public int Terulet()
    {
        int s = (a + b + c) / 2;
        int t = (int)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return t;
    }

    public bool EgyenloSzaru()
    {
        if (b == c || a == c || b == c)
        {
            return true;
        }
        return false;
    }

    public bool Szabalyos()
    {
        if (a != b || a != c)
        {
            return false;
        }
        return true;
    }

    public bool Derekszogu()
    {
        if (a * a + b * b == c * c)
        {
            return true;
        }
        return false;
    }

    public string Szovegesen()
    {
        string válasz = $"{a}, {b}, {c}";
        return válasz;
    }
}