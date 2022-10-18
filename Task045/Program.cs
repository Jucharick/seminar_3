// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] array1 = new Int32[10];
int[] array2 = new Int32[10];

void FillArray(int[] array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine();
}

void CopyArray(int[] array1, int[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array2[i] = array1[i];
    }
}



FillArray(array1, 0, 100);
PrintArray(array1);
CopyArray(array1, array2);
PrintArray(array2);