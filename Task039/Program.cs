// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]




int[] array = new Int32[10];

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

// void Reverse(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++ )
//     {
//         int t = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = t; 
//     }
// }

void ReverseArray(int[] array) // имя метода должно отражать суть метода - реверсия массива
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1 < index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
        index1++;
        index2--;
    }
}


FillArray(array, -9, 10);
PrintArray(array);
// Array.Reverse(array); // встроенный метод, что есть в c#
// Reverse(array);
ReverseArray(array);
PrintArray(array);