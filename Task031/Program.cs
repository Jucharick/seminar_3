// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.



int[] array = new Int32[12];

void FillArray(int[] array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to+1); 
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

void posNeg (int[] array)
{
    int pos = 0;
    int neg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) pos = pos + array[i];
        else neg = neg + array[i];
    }
    Console.WriteLine(pos); 
    Console.WriteLine(neg);
}

FillArray(array, -9, 10);
PrintArray(array);
posNeg(array);