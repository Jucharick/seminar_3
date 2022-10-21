// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5



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
            matr [i, j] = i + j;
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