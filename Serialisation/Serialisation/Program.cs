// See https://aka.ms/new-console-template for more information
using Serialisation;
using System.Text.Json;

Console.WriteLine("Task1: Serialisation");
var grades = new List<int> { 38, 45, 50, 60, 49 };
var student = new Student("Boris", 22, grades);
string json = JsonSerializer.Serialize(student);
Console.WriteLine(json);

Console.WriteLine("\nTask2: Deserialsation");
Student? restoredStudent = JsonSerializer.Deserialize<Student?>(json);
Console.WriteLine($"{restoredStudent.Name} {restoredStudent.Age}");

Console.WriteLine("\nTask3: Serialisation options");

DateTime bookRealise = new DateTime(1995, 10, 1);
var book = new Book("Casino", "Nicholas Pileggi", bookRealise);
var options = new JsonSerializerOptions
{
    WriteIndented = true
};
string json2 = JsonSerializer.Serialize(book, options);
Console.WriteLine(json2);

Console.WriteLine("\nTask3: Work with Collections");

var books = new List<Book>();
bookRealise = new DateTime(2007, 09, 25);
var book1 = new Book("The Wolf of Wall Street", "Jordan Belfort", bookRealise);
bookRealise = new DateTime(1985, 01, 01);
var book2 = new Book("Perfume. The Story of a Murderer", "Patrick Suskind", bookRealise);
books.Add(book);
books.Add(book1);
books.Add(book2);

string json3 = JsonSerializer.Serialize(books, options);
Console.WriteLine(json3);
List<Book>? desBooks = JsonSerializer.Deserialize<List<Book>>(json3);
Console.WriteLine(desBooks);
foreach(var i in desBooks)
{
    Console.WriteLine($"Title:{i.Title} Author:{i.Author} PublishedDate:{i.PublishedDate}");
}

Console.WriteLine("\nTask4: File save JSON");
string json4 = json3;
string dir = "D:\\TOP Accademy\\учебные материалы\\Основы C# и .NET\\ДЗ\\Serialisation";
string file = dir + "\\data.json";
File.WriteAllText(file, json4);
Console.WriteLine(File.ReadAllText(file));
List<Book>? deserial = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText(file));
foreach (var i in deserial)
{
    Console.WriteLine($"Title:{i.Title} Author:{i.Author} PublishedDate:{i.PublishedDate}");
}

