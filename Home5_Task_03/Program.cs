//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
//---------------------------
//double num1 = num * (maximum - minimum) + minimum

double[] GetArray(int newstring)
{
    double[] arr = new double[newstring];
    Random rnd = new Random();

    for (int i = 0; i < newstring; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * 10, 2);
    }
    return arr;
}

void MinMaxDiff(double[] array)
{
    double max = 0;
    double min = array[0];
    double diff = 0;

    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            if (array[i] < array[0]) min = array[i];
        }
    diff = Math.Round((max - min), 2);


Console.WriteLine($"МАХ значение массива: {max}");
Console.WriteLine($"МIN значение массива: {min}");
Console.WriteLine($"Разность MAX и MIN значений: {diff}");
}

double[] array = GetArray(10);

Console.Write("Массив чисел на входе: [");
Console.Write(string.Join(", ", array));
Console.Write("]");

Console.WriteLine();
Console.WriteLine($"-------------------------------------------------------------------------------");

MinMaxDiff(array);