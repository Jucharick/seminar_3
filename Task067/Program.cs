// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine();
SumOfNumbers(number);

void SumOfNumbers(int number) 
{

    if(number == stop ) {
        Console.Write(number);
    } else {
        Console.Write(number);
        SumOfNumbers();
    }
}
