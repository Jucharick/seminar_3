// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


Console.WriteLine("Введите высоту матрицы (количество строк)");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int columns = int.Parse(Console.ReadLine());

int [,] matrix  = CreateMatrixRndInt(rows, columns, -100, 100);
PrintMatrix(matrix);


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            matrix[i, j] = i + j;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j], 4} | "); // 4 - для выравнивания вывода матрицы
            else Console.Write($" {matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}


// Console.WriteLine("Введите высоту матрицы (количество строк)");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите длину матрицы (количество столбцов)");
// int n = int.Parse(Console.ReadLine());

// int [,] matrix  = new int [m, n];

// void FillMatrix(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // идем по строкам
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // идем по колонкам
//         {
//             matr [i, j] = i + j;
//         }
//     }
// }

// void PrintMatrix(int [,] matr) 
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // идем по строкам
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // идем по колонкам
//         {
//         Console.Write($" {matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// FillMatrix(matrix);
// PrintMatrix(matrix);