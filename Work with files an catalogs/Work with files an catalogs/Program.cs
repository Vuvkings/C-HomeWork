// See https://aka.ms/new-console-template for more information
using System.IO;
using Work_with_files_an_catalogs;

Console.WriteLine("Task1: Создание и управление каталогами ");

string dirName1 = "D:\\TOP Accademy\\учебные материалы\\Основы C# и .NET\\ДЗ\\Work with files an catalogs\\Example\\Subfolder1";
string dirName2 = "D:\\TOP Accademy\\учебные материалы\\Основы C# и .NET\\ДЗ\\Work with files an catalogs\\Example\\Subfolder2";

var task1 = new Task1(dirName1);    //Создание Обьекта
var task2 = new Task1(dirName2);
task1.AddCatalog();                 //Создание дирректорий
task2.AddCatalog();
task1.RemoveCatalog();              //Удаление дирректорий
task2.RemoveCatalog();

Console.WriteLine("\nTask2: Работа с файлами");

string path1 = "D:\\TOP Accademy\\учебные материалы\\Основы C# и .NET\\ДЗ\\Work with files an catalogs\\Example\\text2.txt";
string path2 = "D:\\TOP Accademy\\учебные материалы\\Основы C# и .NET\\ДЗ\\Work with files an catalogs\\Example2";

try
{
    File.WriteAllText(path1, "Hello, World!");      //Создание и запись файла
    File.AppendAllText(path1, "\nnew String");      //Добавление новой строки

    Console.WriteLine(File.ReadAllText(path1));

    int iterator = 1;
    foreach (var str in File.ReadLines(path1))
    {
        Console.WriteLine($"{iterator} {str}");
        iterator++;
    }

    string copyFile = path2 + "\\text(copy).txt";
    string moveFile = path2 + "\\text(move).txt";
    //System.IO.IOException
    //File.Copy(path1, copyFile);
    File.Move(path1, moveFile);
}
catch (IOException ex)
{
    Console.WriteLine($"Ошибка ввода-вывода. Подробности: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Неизвестная ошибка. Подробности: {ex.Message}");
}




Console.WriteLine("\nTask3: Работа с FileStream");
try
{
    string file = path2 + "\\text3.txt";
    using (FileStream fileStream = new FileStream(file, FileMode.Create, FileAccess.Write))
    {
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.WriteLine("Красов");
            writer.WriteLine("Артем");
            writer.WriteLine("Александрович");
        }
    }

    using (FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read))
    {
        using (StreamReader reader = new StreamReader(fileStream))
        {
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine($"Ошибка ввода-вывода. Подробности: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Неизвестная ошибка. Подробности: {ex.Message}");
}



Console.WriteLine("\nTask4: Меню для работы с файлами");

Menu();

void Menu()
{
    string directoryPath = "D:\\TOP Accademy\\учебные материалы\\Основы C# и .NET\\ДЗ\\Work with files an catalogs";
    string menuPath = "\\menuText.txt";

    Directory.CreateDirectory(directoryPath);
    string file = directoryPath + menuPath;
    int position = 0;
    int oldPosition = 0;

    bool closeProgramm = false;
    Console.WriteLine(file);
    //WriteTextInFile(file);
    //ReadTextFromFile(file);
    int chose;
    Console.WriteLine("1: Запись файла");
    Console.WriteLine("2: Чтение файла");
    Console.WriteLine("3: Выход");
    while (closeProgramm == false)
    {

        chose = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(chose);
        switch (chose)
        {
            case 1:
                {
                    Console.WriteLine("Запись файла");
                    WriteTextInFile(file);
                    break;
                }
            case 2:
                {
                    ReadTextFromFile(file);
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Выход");
                    closeProgramm = Exit();
                    break;
                }
            default: break;
        }
    }
}

void WriteTextInFile(string filePath)
{
    try
    {
        Console.WriteLine("Запишите данные в файл");
        string text = Console.ReadLine();

        File.WriteAllText(filePath, text);
    }
    catch (IOException ex)
    {
        Console.WriteLine($"Ошибка ввода-вывода. Подробности: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Неизвестная ошибка. Подробности: {ex.Message}");
    }
}

void ReadTextFromFile(string filePath)
{
    try
    {
        Console.WriteLine("Чтение файла:");

        Console.WriteLine(File.ReadAllText(filePath));
    }
    catch (IOException ex)
    {
        Console.WriteLine($"Ошибка ввода-вывода. Подробности: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Неизвестная ошибка. Подробности: {ex.Message}");
    }
}

bool Exit() { return true; }