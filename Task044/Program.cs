// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



// f(n) = f(n-1) + f(n-2)

Console.WriteLine("Введите количество:");
int a = int.Parse(Console.ReadLine());

Console.Write("0 1");
int first = 0;
int second = 1;
int next = 0;

for (int i = 1; i < a - 1; i++) // выведите первые N чисел
{
    next = first + second;
    first = second;
    second = next;
    Console.Write(" " + next);
}