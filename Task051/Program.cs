// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали


Console.WriteLine("Введите высоту матрицы (количество строк)");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m, n];


FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Sum(matrix);



void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // идем по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) // идем по колонкам
        {
            matr[i, j] = new Random().Next(1, 10); // интервал будте от -10 до 9 (10 не включается)
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // идем по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) // идем по колонкам
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// void Sum(int[,] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++) // идем по строкам
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // идем по колонкам
//         {
//                 if ( i == j)
//                 {
//                     sum = sum + matr[i, j];
//                 }
//         }
//     }
//     Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {sum}");
// }

void Sum(int[,] matr)
{
    int sum = 0;
    int min = 0;
    if (matr.GetLength(0) > matr.GetLength(1)) min = matr.GetLength(1);
    else min = matr.GetLength(0);
    for (int i = 0; i < min; i++)
    {
        sum = sum + matr[i, i]; // можем идти только по индексу i, так как на главной диагонали индексы равны - 1 1, 2 2 и т.д.
    }
    Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {sum}");
}