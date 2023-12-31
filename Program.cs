﻿string[] CreateStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintStringArray(string[] array, bool isNotNullElements)
{
    if (isNotNullElements)
    {
        Console.Write($"[");
        if (array[0] != null) Console.Write($"'{array[0]}'");
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] != null) 
            Console.Write($", '{array[i]}'");
        }
        Console.Write("]");
    }
    else
    {
        Console.Write($"['{array[0]}'");
        for (int i = 1; i < array.Length; i++)
        {
            Console.Write($", '{array[i]}'");
        }
        Console.Write("]");
    }
}

string[] CreateArrayWithElementsOf3letters(string[] array)
{
    string[] partialArray = new string[array.Length];

    int countElements = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            partialArray[countElements] = array[i];
            countElements++;
        }
    }
    return partialArray;
}

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Write("Input size of Array: ");
int size = int.Parse(Console.ReadLine());

string[] stringArray = new string[size];

stringArray = CreateStringArray(stringArray);

string[] partialArray = new string[size];

partialArray = CreateArrayWithElementsOf3letters(stringArray);

PrintStringArray(stringArray, false);
Console.Write("--> ");
PrintStringArray(partialArray, true);