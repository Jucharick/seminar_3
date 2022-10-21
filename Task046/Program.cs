Console.WriteLine("Введите высоту матрицы (количество строк)");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину матрицы (количество столбцов)");
int n = int.Parse(Console.ReadLine());

int [,] matrix  = new int [m, n];

void FillMatrix(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // идем по строкам
    {
        for (int j = 0; j < matr.GetLength(1); j++) // идем по колонкам
        {
            matr [i, j] = new Random().Next(-10, 10); // интервал будте от -10 до 9 (10 не включается)
        }
    }
}

void PrintMatrix(int [,] matr) 
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

FillMatrix(matrix);
PrintMatrix(matrix);