// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10



// int x = 45;
// Console.WriteLine(Convert.ToString(x, 2));


Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

// string count = null;
// while (number != 0)
// {
//     count += number % 2;
//     number /= 2;
// }

// for (int i = count.Length - 1; i >= 0; i--)
// {
//     Console.Write(count[i]);
// }

void ConvertToBin (int num)
{ 
    string bin = default;

    if (num > 0)
    {
        bin += num % 2;
        ConvertToBin (num / 2);
    }

    Console.Write(bin);
}

ConvertToBin(number);