// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"



Console.WriteLine("Задайте значение N");
int n = int.Parse(Console.ReadLine());

PrintNaturalNumbers(n);
Console.WriteLine();
printNaturalNumbers(1);

void PrintNaturalNumbers(int n)
{
    int number = 1;
    if (number <= n) 
    {
        PrintNaturalNumbers(n-1);
        Console.Write($" {n}");
    }
}


void printNaturalNumbers(int number) {

    if(n == number ) {
        Console.Write(number);
    } else {
        Console.Write(number);
        printNaturalNumbers(number+1);
    }
}