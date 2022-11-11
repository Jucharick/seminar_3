// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень");
int degree = int.Parse(Console.ReadLine());

Console.WriteLine(Exponentiation(number, degree));

int Exponentiation(int n, int degree)
{
    if (degree == 1) return n;
    else return Exponentiation(n, degree - 1) * n;
}