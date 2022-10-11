// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите целое число n");
// string n = Console.ReadLine();
// int length = n.Length;
// Console.WriteLine(length);

Console.WriteLine("Введите целое число n");
int n = int.Parse(Console.ReadLine());
int i = 0;
while (n != 0)
{
    n = n / 10;
    i++;
}
Console.WriteLine(i);