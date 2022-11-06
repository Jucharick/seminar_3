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

