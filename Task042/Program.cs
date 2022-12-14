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

// for (int i = count.Length - 1; i >= 0; i--) // реверс, потому что при переводе в двоичную систему число начинается с последнего остатка от деления на 2
// {
//     Console.Write(count[i]);
// }

void ConvertToBin (int num)
{ 
    string bin = default;

    if (num > 0)
    {
        bin += num % 2;
        
        // стек = это структура данных, которая работает по принципу первый пришел - последний ушел
        // можно представить стопку книг - мы не можем взять первую, пока не снимим все верхние по порятку, начиная с последней
        
        ConvertToBin (num / 2); // при рекурсии реверс делать не нужно, потому что рекурсия работает со стеком
        
        // разберем пример с number = 13
        // 4) num / 2 => 1
        // 3) num / 2 => 3
        // 2) num / 2 => 6
        // 1) num     => 13
        //
        // выводить будет начиная с остатка от деления с последнего вызова ConvertToBin (num / 2); ( c пунка 4)
        // => 1101

    }

    Console.Write(bin);
}

void ConvertToBin2 (int num)
{
    if (num == 0) return;
    ConvertToBin (num / 2);
    Console.Write(num % 2);
}

ConvertToBin(number);
Console.WriteLine();
ConvertToBin2(number);