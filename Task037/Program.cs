// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



int len = new Random().Next(5, 10);
Console.WriteLine(len);

int[] arr = new Int32[len];

double half = Math.Ceiling((Convert.ToDouble(len) / 2));
Console.WriteLine(half);

int[] arr2 = new Int32[Convert.ToInt32(half)];


fillMass(arr, 1, len);
printArray(arr);
numFind(arr, arr2);
printArray(arr2);

int[] fillMass(int[] array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine();
}

int[] numFind(int[] array, int[] array2)
{
    for (int i = 0; i < (array.Length)/2; i++)
    {
        array2[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0)
    {
        array2[array.Length / 2] = array[array.Length / 2];
    }
    return array2;
}
