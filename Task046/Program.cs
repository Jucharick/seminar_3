


int [,] matrix  = new int [3, 4];

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


FillMatrix(matrix);
PrintMatrix(matrix);