// Console.WriteLine("Введите номер четверти (от 1 до 4)");
// int x = Convert.ToInt32(Console.ReadLine());

// if (x < 1 | x > 4)
// {
//     Console.WriteLine("Вы ввели некорректное значение");
// }
// else if (x == 1)
// {
//     Console.WriteLine("Первая четверть: x > 0 и y > 0");
// }
// else if (x == 2)
// {
//     Console.WriteLine("Вторая четверть: x < 0 и y > 0");
// }
// else if (x == 3)
// {
//     Console.WriteLine("Третья четверть: x < 0 и y < 0");
// }
// else if (x == 4)
// {
//     Console.WriteLine("Четвертая четверть: x > 0 и y < 0");
// }


// так как ReadLine() принимает строкове значение и мы в программе не используем математические конструкции (деление, умножение и т.д., то правильнее использовать в данном случае строковый тип данных)

Console.WriteLine("Введите номер четверти (от 1 до 4)");
string x = Console.ReadLine();

if (x == "1")
{
    Console.WriteLine("Первая четверть: x > 0 и y > 0");
}
else if (x == "2")
{
    Console.WriteLine("Вторая четверть: x < 0 и y > 0");
}
else if (x == "3")
{
    Console.WriteLine("Третья четверть: x < 0 и y < 0");
}
else if (x == "4")
{
    Console.WriteLine("Четвертая четверть: x > 0 и y < 0");
}
else 
{
    Console.WriteLine("Вы ввели некорректное значение");
}