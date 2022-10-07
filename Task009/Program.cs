Console.Clear();
Console.WriteLine("Введите X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Первая четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Четвертая четверть");
}