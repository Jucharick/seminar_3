double n = -123.454968968;

Console.WriteLine(Math.Abs(n));         // 123,454968968
Console.WriteLine(Math.Round(n));       // -123
Console.WriteLine(Math.Round(n, 5));    // -123,45497
Console.WriteLine(Math.Round(n, 2));    // -123,45
Console.WriteLine(Math.Ceiling(n));     // -123
Console.WriteLine(Math.Floor(n));       // -124
Console.WriteLine(Math.Truncate(n));    // -123
Console.WriteLine(Math.Sign(n));        // -1

int a = 4;
Console.WriteLine(Math.Sqrt(a));        // 2
Console.WriteLine(Math.Pow(a, 2));      // 16
Console.WriteLine(Math.Pow(a, 3));      // 64

double b = 4.456;
Console.WriteLine(Math.Pow((Math.Truncate(b)), 3));  // 64