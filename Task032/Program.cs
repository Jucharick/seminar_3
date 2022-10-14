// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 




int[] array = new Int32[4];

void FillArray(int[] array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to+1); 
    }
}
 
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, "); 
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine();
}

void signChange (int[] arr)
{
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}

FillArray(array, -9, 10);
PrintArray(array);
signChange(array);
PrintArray(array);