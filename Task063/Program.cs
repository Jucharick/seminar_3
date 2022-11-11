// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"



Console.WriteLine("Задайте значение N");
int n = int.Parse(Console.ReadLine());

PrintNaturalNumbers(n);

void PrintNaturalNumbers(int n)
{
    int number = 1;
    if (number <= n) 
    {
        PrintNaturalNumbers(n-1);
        Console.Write($" {n}");
    }
}