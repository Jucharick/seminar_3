Console.Clear();
Console.WriteLine("Введите номер четверти (от 1 до 4)");
int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите Y");
// int y = Convert.ToInt32(Console.ReadLine());

if (x < 1 | x > 4)
{
    Console.WriteLine("Вы ввели некорректное значение");
}
else if (x == 1)
{
    Console.WriteLine("Первая четверть: x > 0 и y > 0");
}
else if (x == 2)
{
    Console.WriteLine("Вторая четверть: x < 0 и y > 0");
}
else if (x == 3)
{
    Console.WriteLine("Третья четверть: x < 0 и y < 0");
}
else if (x == 4)
{
    Console.WriteLine("Четвертая четверть: x > 0 и y < 0");
}