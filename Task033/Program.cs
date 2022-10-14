// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, "); 
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine();
}

FillArray(array, -9, 10);
PrintArray(array);

Console.WriteLine("Введите целое число:");
int n = Convert.ToInt32(Console.ReadLine());

string result = search(array, n)? $"Число {n} входит в массив": "Число {n} не входит в массив";
Console.WriteLine(result);

bool search(int[] array, int n)
{
    bool h = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n) 
        {
            h = true;
            break;
        } 
    }
    return h;
}