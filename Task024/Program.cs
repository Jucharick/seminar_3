// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.WriteLine("Введите целое число n");
int n = int.Parse(Console.ReadLine());
int sum = 0;
while (n < 1)
{
    Console.WriteLine("Значение некорректно, попробуйте еще раз: ");
    n = Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i <= n; i++)
{
    sum = sum + i;
}
Console.Write($"Сумма от 1 до {n} = {sum}");