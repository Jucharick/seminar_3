// Задача 55:
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.



Console.WriteLine("Введите высоту матрицы (количество строк)");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int columns = int.Parse(Console.ReadLine());

int [,] matrix = CreateMatrixRndInt(rows, columns, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
if (matrix.GetLength(0) == matrix.GetLength(1))
{
    int [,] transpResult = MatrixTransposition(matrix);
    PrintMatrix(transpResult);
}
else Console.WriteLine($"Заменить строки на столбцы в вашей матрие не возможно, потому что она не квадратная");
Console.WriteLine("----------------");
MatrixTransposition2(matrix);
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

void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j], 2} | "); // 2 - для выравнивания вывода матрицы выводим по 4 символа
            else Console.Write($" {matrix[i, j], 2} ");
        }
        Console.WriteLine("|");
    }
}

int[,] MatrixTransposition(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[j, i] = matrix[i, j];
        }
    }
    return result;
}

void MatrixTransposition2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++) // j = i - диагональ у квадратной матрицы сохраняется. Иначе замена происходит дважды
        {
            int temp = matrix[j, i];
            matrix[j, i]= matrix[i, j];
            matrix[i, j] = temp;
        }
    }
}