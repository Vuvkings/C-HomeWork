// See https://aka.ms/new-console-template for more information
using Student_List_LINQ;

Console.WriteLine("Hello, World!");


var student1 = new Student("Boba", 18, 3);
var student2 = new Student("Vladislave", 21, 3.5);
var student3 = new Student("Kiril", 20, 3.8);
var student4 = new Student("Samuel", 23, 4);
var student5 = new Student("Erick", 24, 5);
var student6 = new Student("Gordon", 19, 5);
var student7 = new Student("Arnold", 20, 4.5);


var listStudents = new List<Student>();
listStudents.Add(student1);
listStudents.Add(student2);
listStudents.Add(student3);
listStudents.Add(student4);
listStudents.Add(student5);
listStudents.Add(student6);
listStudents.Add(student7);

var selectStudents = from s in listStudents
                     where s.GPA >= 3.5 && s.Age >= 20
                     select s;
foreach (var student in selectStudents)
    Console.WriteLine($"Sorted by GPA: {student.Name}");
