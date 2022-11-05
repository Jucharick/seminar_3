// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] arr = CreateArrayRndInt(5, 0, 10);
// int[] array2 = new Int32[10];
int[] arr2 = CopyArray(arr);


PrintArray(arr);
PrintArray(arr2);


int[] CreateArrayRndInt(int size, int from, int to)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(from, to + 1);
    }
    return array;
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

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

// void FillArray(int[] array, int from, int to)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(from, to);
//     }
// }

// void CopyArray(int[] array1, int[] array2)
// {
//     for (int i = 0; i < array1.Length; i++)
//     {
//         array2[i] = array1[i];
//     }
// }