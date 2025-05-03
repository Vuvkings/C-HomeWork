// See https://aka.ms/new-console-template for more information
using System.IO;
using Work_with_files_an_catalogs;

//Console.WriteLine("Task1: Создание и управление каталогами ");

//string dirName1 = "D:\\TOP Accademy\\учебные материалы\\Основы C# и .NET\\ДЗ\\Work with files an catalogs\\Example\\Subfolder1";
//string dirName2 = "D:\\TOP Accademy\\учебные материалы\\Основы C# и .NET\\ДЗ\\Work with files an catalogs\\Example\\Subfolder2";

//var task1 = new Task1(dirName1);
//var task2 = new Task1(dirName2);
//task1.AddCatalog();
//task2.AddCatalog();
//task1.RemoveCatalog();
//task2.RemoveCatalog();

Console.WriteLine("\nTask2: Работа с файлами");

string path1 = "D:\\TOP Accademy\\учебные материалы\\Основы C# и .NET\\ДЗ\\Work with files an catalogs\\Example\\text.txt";
string path2 = "D:\\TOP Accademy\\учебные материалы\\Основы C# и .NET\\ДЗ\\Work with files an catalogs\\Example2";

//File.Create(path1);
File.WriteAllText(path1, "Hello, World!");
File.AppendAllText(path1, "\nnew String");
Console.WriteLine(File.ReadAllText(path1));

int iterator = 1;
foreach(var str in File.ReadLines(path1))
{
    Console.WriteLine($"{iterator} {str}");
    iterator++;
}

string copyFile = path2 + "\\text(copy).txt";
string moveFile = path2 + "\\text(move).txt";

File.Copy(path1, copyFile);
File.Move(path1, moveFile);

//File.ReadAllText(path1);


