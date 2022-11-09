// Работа с директориями


string path1 = "/Users/Юлия Чарикова/Desktop/GeekBrains/I четверть/3_Знакомство с языками программирования/Урок 1. ДЗ/Ex057";
DirectoryInfo di = new DirectoryInfo(path1);
Console.WriteLine(di.CreationTime); // показывает когда была создана папка
FileInfo[] fi = di.GetFiles(); // показывает что хранится в папке => создает массив

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name); // показывает имя файлов
}

void CatalogInfo(string path, string indent = "") // string indent = "" это искусственный прием, позволяющий делать отступы, чтобы видеть структуру папок
{
    DirectoryInfo catalog = new DirectoryInfo(path); // информация о той директории, в которую мы зашли
    DirectoryInfo[] catalogs = catalog.GetDirectories(); // получаем массив всех файлов, находящихся в этой папке
    for (int i = 0; i < catalogs.Length; i++) // пробегаем по массиву всех файлов
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}"); // выводя информацию о текущем каталоге
        CatalogInfo(catalogs[i].FullName, indent + " "); // рекурсивно заходим во все папки, которые будут получены в DirectoryInfo[] catalog = catalog.GetDirectories();
    }

    FileInfo[] files = catalog.GetFiles(); // получаем весь список файлов текущей директории
    
    for (int i = 0; i < files.Length; i++) // пробегаем по массиву всех файлов
    {
        Console.WriteLine($"{indent}{files[i].Name}"); // показываем эти файлы
    }

}
string path = @"/Users/Юлия Чарикова/Desktop/GeekBrains/I четверть/3_Знакомство с языками программирования/Урок 1. ДЗ";
CatalogInfo(path);