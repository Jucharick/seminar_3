// Задача 59:
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен 
// наименьший элемент массива
//
//
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//
// Наименьший элемент - 1
// Результат =>
//
// 9 2 3
// 4 2 4
// 2 6 7


Console.WriteLine("Введите высоту матрицы (количество строк)");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(rows, columns, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[,] deleteRowCol = CreateMatrixWithoutMinElRowCol(matrix, GetIndexForMinElement(matrix));
PrintMatrix(deleteRowCol);


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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j],2} | "); // 2 - для выравнивания вывода матрицы выводим по 2 символа
            else Console.Write($" {matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}

int[] GetIndexForMinElement(int[,] matrix)
{
    int[] indexIJ = new int[2]; // координаты min имеют два индекса
    int min = matrix[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
    Console.WriteLine($"min = {min} с координатами ({minI}  {minJ})");
    return indexIJ;
}

int[,] CreateMatrixWithoutMinElRowCol(int[,] matrix, int[] indexIJ)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1]; // результирующая матрица будет меньше, поскольку мы удаляем одну строку и один столбец
    int resultI = 0;
    int resultJ = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows
    {
        if (i != indexIJ[0])
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
            {
                if (j != indexIJ[1])
                {
                    result[resultI, resultJ] = matrix[i, j];
                    resultJ ++;
                }
            }
            resultI ++;
        }
    }
    return result;
}