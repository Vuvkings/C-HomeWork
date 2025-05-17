// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine(stack.Peek()); // Вывод: 3
Console.WriteLine(stack.Pop()); // Вывод: 3
Console.WriteLine(stack.Pop()); // Вывод: 2
Console.WriteLine(stack.Pop()); // Вывод: 1