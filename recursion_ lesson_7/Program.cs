// Работа с директориями


string path = "/Users/Юлия Чарикова/Desktop/GeekBrains/I четверть/3_Знакомство с языками программирования/Урок 1. ДЗ/Ex057";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime); // показывает когда была создана папка
FileInfo[] fi = di.GetFiles(); // показывает что хранится в папке => создает массив

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name); // показывает имя файлов
}