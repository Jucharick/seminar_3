// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


bool correct = true;
while (correct)
{
    try
    {
        Console.Write("Введите N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        List<int> array = new List<int>(); // ??????

        if (N > 0)
        {
            for (double i = 1; i <= N; i++)
            {
                array.Add(Convert.ToInt32(Math.Pow(i, 2)));
            }
        }
        Console.Write(String.Join(", ", array));
        correct = false;
    }
    catch
    {
        Console.WriteLine("Введено неверное значение");
    }
}

// for (int i = 1; i <= N; i++)
// {
//     Console.Write();
// }