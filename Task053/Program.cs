// Задача 53:
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.



Console.WriteLine("Введите высоту матрицы (количество строк)");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int columns = int.Parse(Console.ReadLine());

int [,] matrix  = CreateMatrixRndInt(rows, columns, 0, 10);
PrintMatrix(matrix);
ReplaceRows(matrix);
Console.WriteLine();
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j], 2} | "); // 2 - для выравнивания вывода матрицы выводим по 2 символа
            else Console.Write($" {matrix[i, j], 2} ");
        }
        Console.WriteLine("|");
    }
}

int [,] ReplaceRows(int [,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns идем по колонкам, строки нам известны - это первая и последняя (идти по ним не нужно)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
    return matrix;
}