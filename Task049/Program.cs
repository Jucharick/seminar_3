// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
//
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//
//  1  4 49 2
//  5  9  2 3
// 64  4  4 4


Console.WriteLine("Введите высоту матрицы (количество строк)");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int columns = int.Parse(Console.ReadLine());

int [,] matrix  = CreateMatrixRndInt(rows, columns, 0, 10);

PrintMatrix(matrix);
Console.WriteLine();
ReplaceEvenElementsMatrix(matrix);
PrintMatrix(matrix);


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
    for (int i = 0; i < matrix.GetLength(0); i++) // идем по строкам
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) // идем по колонкам
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j], 4} | "); // 4 - для выравнивания вывода матрицы выводим по 4 символа
            else Console.Write($" {matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] ReplaceEvenElementsMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2) // идем по строкам  шагом 2 для того, чтобы найти чётные индексы
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2) // идем по колонкам с шагом 2 для того, чтобы найти чётные индексы
        {
            matrix[i, j] *= matrix[i, j]; // равносильно matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
    return matrix;
}






// Console.WriteLine("Введите высоту матрицы (количество строк)");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите длину матрицы (количество столбцов)");
// int n = int.Parse(Console.ReadLine());

// int[,] matrix = new int[m, n];

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

// // void Squared(int[,] matr)
// // {
// //     for (int i = 0; i < matr.GetLength(0); i++) // идем по строкам
// //     {
// //         for (int j = 0; j < matr.GetLength(1); j++) // идем по колонкам
// //         {
// //             if (i % 2 == 0 && j % 2 == 0)
// //             {
// //                 matr[i, j] = matr[i, j] * matr[i, j] ;
// //             }
// //         }
// //     }
// // }

// void Squared(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i+=2) // идем по строкам
//     {
//         for (int j = 0; j < matr.GetLength(1); j+=2) // идем по колонкам
//         {
//                 matr[i, j] = matr[i, j] * matr[i, j] ; // так алгоритм работает быстрее, чем с if
//         }
//     }
// }


// FillMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// Squared(matrix);
// PrintMatrix(matrix);