//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
//-------------------------

int[] GetArray(int newstring)
{
    int[] arr = new int[newstring];
    Random rnd = new Random();

    for (int i = 0; i < newstring; i++)
    {
        arr[i] = rnd.Next(-10, 10);
    }
    return arr;
}

void EvenOddNumber(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
        {
          sum += array[i]++;
        }
    }
    Console.WriteLine($"Кол-во элементов на нечетных позициях: {sum}");
}

int[] array = GetArray(4);

Console.Write("Массив чисел на входе: [");
Console.Write(string.Join(", ", array));
Console.Write("]");

Console.WriteLine();
Console.WriteLine($"-------------------------------------------------------------------------------");

EvenOddNumber(array);