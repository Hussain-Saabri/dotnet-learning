//In C#, methods are almost always tied to a class or struct. They are highly structured and support complex features like overloading and optional parameters.

//A method is a block of code that performs a specific task and can be called (invoked) from other parts of your program.

void Greet(string name)
{
    Console.WriteLine("1. Void Method");
    Console.WriteLine($"Hello, {name}");
}
int multiply(int a, int b)
{
    Console.WriteLine("2. Non-void Method");
    return a * b;
}
//Default parameters:

 void PrintMessage(string msg, int times = 1)
{
    for (int i = 0; i < times; i++)
        Console.WriteLine(msg);
}

Greet("Hussain");
Console.WriteLine(multiply(2, 3));
Console.WriteLine("Default parameters:");
PrintMessage("Hello");
PrintMessage("Hello", 3);

