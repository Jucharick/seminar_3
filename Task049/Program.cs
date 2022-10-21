// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


Console.WriteLine("Введите высоту матрицы (количество строк)");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m, n];

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

// void Squared(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // идем по строкам
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // идем по колонкам
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matr[i, j] = matr[i, j] * matr[i, j] ;
//             }
//         }
//     }
// }

void Squared(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i+=2) // идем по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j+=2) // идем по колонкам
        {
                matr[i, j] = matr[i, j] * matr[i, j] ; // так алгоритм работает быстрее, чем с if
        }
    }
}


FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Squared(matrix);
PrintMatrix(matrix);