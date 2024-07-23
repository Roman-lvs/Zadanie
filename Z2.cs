int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}

void Main()
{
    int m = 3, n = 2;
    int result = Ackermann(m, n);
    Console.WriteLine($"A({m}, {n}) = {result}");
}

Main();
