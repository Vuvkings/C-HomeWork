// See https://aka.ms/new-console-template for more information


Console.WriteLine("Task1:\n");

DoOperation(5, 4, Add);         // 9
DoOperation(5, 4, Substract);    // 1
DoOperation(5, 4, Multiply);    // 20


void DoOperation(int a, int b, Operation operation)
{
    Console.WriteLine(operation(a, b));
}

int Add(int a, int b) { return a + b; }

int Substract(int a, int b) { return a - b; }

int Multiply(int a, int b) { return a * b; }

Console.WriteLine("Task2:\n");

// int ModifyList(int count) 
//{
//    Func<int, int> lambdaFunc = (a) => ++a;
//    count = lambdaFunc(count);

//    return count; 
//}
List<int> ints = new List<int>() {1, 2, 3, 4, 5};
Console.WriteLine(ints[1]);
List<int> ModifyList(List<int> list) 
{
    //Console.WriteLine("Old list:");
    //for (int i = 0; i< list.Count; i++) 
    //{ 
    //    Console.WriteLine(list[i]); 
    //}

    Func<int, int> lambdaFunc = (a) => ++a;
    Console.WriteLine("New list:");
    for (int i = 0; i < list.Count; i++)
    {
        list[i] = lambdaFunc(list[i]);
        Console.WriteLine(list[i]);
    }
    return list;  
}

Console.WriteLine(ModifyList(ints));
int sum(int a, int b) { return a + b; }
Console.WriteLine(sum(1,3));
delegate int Operation(int a, int b);




