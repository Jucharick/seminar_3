Console.WriteLine("Введите высоту матрицы (количество строк)");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int columns = int.Parse(Console.ReadLine());

int [,] matrix  = CreateMatrixRndInt(rows, columns, 0, 10);
PrintMatrix(matrix);


// void FillMatrix(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // идем по строкам
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // идем по колонкам
//         {
//             matr [i, j] = new Random().Next(-10, 10); // интервал будте от -10 до 9 (10 не включается)
//         }
//     }
// }

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
        for (int j = 0; j < matrix.GetLength(1); j++) // идем по колонкам
        {
        Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}