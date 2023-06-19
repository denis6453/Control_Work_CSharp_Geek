string[] CreateStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("\n");
}


