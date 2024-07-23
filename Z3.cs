void Main()
{
    int[] array = {1, 2, 3, 4, 5 };
    PrintArray(array, array.Length - 1);
}

void PrintArray(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        PrintArray(array, index - 1);
    }
}

Main();
