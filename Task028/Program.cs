﻿// factorial

Console.WriteLine("Введите целое число n");
int input = int.Parse(Console.ReadLine());

int factorial(int multip)
{
    multip = 1;
    for (int i = 1; i <= input; i++)
    {
        multip = multip * i;
    }
    return multip;
}
Console.Write($"Произведение чисел от 1 до {input} = {factorial(input)}");