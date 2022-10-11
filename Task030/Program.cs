// Задача 30: 
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// 1,0,1,1,0,1,0,0


int[] tempMass = new int[8];
void randomMass(int[] array) // потому что ничего не возвращает
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 2); // 2 не включается
    }
}


randomMass(tempMass);


void printMass(int[] array) // потому что ничего не возвращает
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length - 1)) Console.Write($", ");
        // Console.Write(array[i] + " ");
    }
}
printMass(tempMass);