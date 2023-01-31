//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
//------------------------------
// Решение через  int

int[] GetArray(int newstring)
{
    int[] arr = new int[newstring];
    Random rnd = new Random();

    for (int i = 0; i < newstring; i++)
    {
        arr[i] = rnd.Next(100, 999);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("Массив чисел на входе: [");

    Console.Write(string.Join(", ", arr));
    Console.Write("]");
}

int EvenOddNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       // int count = 0;

        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = GetArray(10);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"-------------------------------------------------------------------------------");

//EvenOddNumber(array);
int count = EvenOddNumber(array);
Console.WriteLine($"Количество четных чисел в массиве: {count}");

/* Решение через void

int[] GetArray(int newstring)
{
    int[] arr = new int[newstring];
    Random rnd = new Random();

    for (int i = 0; i < newstring; i++)
    {
        arr[i] = rnd.Next(100, 999);
    }
    return arr;
}

void EvenOddNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       // int count = 0;

        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}

int[] array = GetArray(4);

Console.Write("Массив чисел на входе: [");
Console.Write(string.Join(", ", array));
Console.Write("]");

Console.WriteLine();
Console.WriteLine($"-------------------------------------------------------------------------------");

EvenOddNumber(array);

*/