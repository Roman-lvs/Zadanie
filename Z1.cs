void Main(string[] args)
{
    Console.Write("Введите значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    void che(int m, int n)
    {
        if (m > n)
        {
            return;
        }
        Console.Write($"{m}, ");
        che(m + 1, n);
    }
    che(m, n);
}

Main(args);