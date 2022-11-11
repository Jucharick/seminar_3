// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(SumOfNumbers(number));

int SumOfNumbers(int n)
{
    if (n < 10) return n;
    else return SumOfNumbers(n / 10 ) + n % 10;
}
