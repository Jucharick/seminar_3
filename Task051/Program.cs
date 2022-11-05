// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали

Console.WriteLine("Введите высоту матрицы (количество строк)");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int columns = int.Parse(Console.ReadLine());

int [,] matrix  = CreateMatrixRndInt(rows, columns, 0, 10);
int result = SumElementsMainDiagonal(matrix);
PrintMatrix(matrix);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали => {result}");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j], 4} | "); // 4 - для выравнивания вывода матрицы выводим по 4 символа
            else Console.Write($" {matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

int SumElementsMainDiagonal(int[,] matrix)
{
    int sum = 0;
    int count = matrix.GetLength(0) > matrix.GetLength(1) ? 1 : 0; // определяем больше строк или столбцов для того, чтобы узнать сколько будет элементов на главной диагонали
    for (int i = 0; i < matrix.GetLength(count); i++)
    {
        sum = sum + matrix[i, i];
    }
    return sum;
}








// Console.WriteLine("Введите высоту матрицы (количество строк)");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите длину матрицы (количество столбцов)");
// int n = int.Parse(Console.ReadLine());

// int[,] matrix = new int[m, n];


// FillMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// Sum(matrix);



// void FillMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // идем по строкам
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // идем по колонкам
//         {
//             matr[i, j] = new Random().Next(1, 10); // интервал будте от -10 до 9 (10 не включается)
//         }
//     }
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // идем по строкам
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // идем по колонкам
//         {
//             Console.Write($" {matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // void Sum(int[,] matr)
// // {
// //     int sum = 0;
// //     for (int i = 0; i < matr.GetLength(0); i++) // идем по строкам
// //     {
// //         for (int j = 0; j < matr.GetLength(1); j++) // идем по колонкам
// //         {
// //                 if ( i == j)
// //                 {
// //                     sum = sum + matr[i, j];
// //                 }
// //         }
// //     }
// //     Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {sum}");
// // }

// void Sum(int[,] matr)
// {
//     int sum = 0;
//     int min = matr.GetLength(0);
//     if (matr.GetLength(0) > matr.GetLength(1)) min = matr.GetLength(1);
//     for (int i = 0; i < min; i++)
//     {
//         sum = sum + matr[i, i]; // можем идти только по индексу i, так как на главной диагонали индексы равны - 0 0, 1 1, 2 2 и т.д.
//     }
//     Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {sum}");
// }