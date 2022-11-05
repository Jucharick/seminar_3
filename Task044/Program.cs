// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



// f(n) = f(n-1) + f(n-2)

Console.WriteLine("Введите количество:");
int number = int.Parse(Console.ReadLine());

Console.Write("0 1");
int first = 0;
int second = 1;
int next = 0;

for (int i = 1; i < number - 1; i++) // выведите первые N чисел
{
    next = first + second;
    first = second;
    second = next;
    Console.Write(" " + next);
}

void Fibonacci (int num)
{
    int num1 = 0;
    int num2 = 1;
    int next = default;
    Console.Write($"{num1} {num2}");
    for (int i = 2; i < num; i++) // начинаем вывод с индекса 2 (с третьего числа), т.к. первые два числа просто выведем 
    {
        next = num1 + num2;
        Console.Write($" {next}");
        num1 = num2;
        num2 = next;
    }
}
Console.WriteLine();
Fibonacci(number);