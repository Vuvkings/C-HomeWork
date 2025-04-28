// See https://aka.ms/new-console-template for more information
using LINQ_Pracltiks;

Console.WriteLine("Task1: Data Filtration");
var student1 = new Student("Boba", 60);
var student2 = new Student("Vladislave", 71);
var student3 = new Student("Kiril", 85);
var student4 = new Student("Samuel", 90);
var student5 = new Student("Erick", 80);
var student6 = new Student("Gordon", 98);
var student7 = new Student("Arnold", 84);

var students = new List<Student>();
students.Add(student1);
students.Add(student2);
students.Add(student3);
students.Add(student4);
students.Add(student5);
students.Add(student6);
students.Add(student7);

var selectStudents = from s in students
                     where s.Score >= 85
                     select s;
foreach (var student in selectStudents)
    Console.WriteLine($"Students with score >= 85: {student.Name}");

Console.WriteLine("\nTask2: Data Sorting");
var books = new List<Book>()
{
new Book("1984"),
new Book("To Kill a Mockingbird"),
new Book("The Great Gatsby"),
};
var sortedBooks = from b in books
                  orderby b.Title
                  select b;

foreach (var book in sortedBooks)
    Console.WriteLine($"Books sorted by Title: {book.Title}");

Console.WriteLine("\nTask3: Data Grouping");
var products = new List<Product>()
{
    new Product("Apple","Fruits"),
    new Product("Carrot","Vegetables"),
    new Product("Banana","Fruits"),
    new Product("Broccoli","Vegetables")
};

var groppingProducts = from p in products
                       group p by p.Category;

foreach (var category in groppingProducts)
{
    Console.WriteLine($"{category.Key}:");
    foreach (var product in category) Console.WriteLine(product.Name);
}
Console.WriteLine("\nTask4: Data Merging");

var students2 = new List<OtherStudent>()
{
    new OtherStudent( 1, "Alice"),
    new OtherStudent( 2, "Bob")
};

var grades = new List<Grade>
{
    new Grade(1,"Math",'A'),
    new Grade(2,"Math",'B'),
    new Grade(1,"Science",'A')
};

var studentsGrades = from s in students2
                     join g in grades on s.Id equals g.StudentId
                     select new {Id = s.Id, Name = s.Name, Subject = g.Subject, LetterGrade = g.LetterGrade};
foreach (var student in studentsGrades)
{
    Console.WriteLine($"{student.Id} {student.Name} {student.Subject} {student.LetterGrade}");
}

Console.WriteLine("\nTask5: Data Aggregation");
var orders = new List<Order>()
{
    new Order(150.00m),
    new Order(200.00m),
    new Order(75.00m)
};
decimal orderSum = orders.Sum((s) => s.Amount);
Console.WriteLine($"You're check: {orderSum}");
/*
var employees = from p in people
             join c in companies on p.Company equals c.Title
             select new { Name = p.Name, Company = c.Title, Language = c.Language };

var students = new List<Student>
{
new Student { Id = 1, Name = "Alice" },
new Student { Id = 2, Name = "Bob" }
};
var grades = new List<Grade>
{
new Grade { StudentId = 1, Subject = "Math", LetterGrade = 'A' },
new Grade { StudentId = 2, Subject = "Math", LetterGrade = 'B' },
new Grade { StudentId = 1, Subject = "Science", LetterGrade = 'A' }
};
}   
 */
