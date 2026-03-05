using System;

Console.WriteLine("Simple Calculator ---");

while (true)
{
    
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option (1-5): ");
    
    string choice = Console.ReadLine();

    if (choice == "5") break;

    Console.Write("Enter first number: ");
    double n1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter second number: ");
    double n2 = Convert.ToDouble(Console.ReadLine());

   
    switch (choice)
    {
        case "1":
            Console.WriteLine($"Result: {n1} + {n2} = {n1 + n2}");
            break;
        case "2":
            Console.WriteLine($"Result: {n1} - {n2} = {n1 - n2}");
            break;
        case "3":
            Console.WriteLine($"Result: {n1} * {n2} = {n1 * n2}");
            break;
        case "4":
            if (n2 != 0)
                Console.WriteLine($"Result: {n1} / {n2} = {n1 / n2}");
            else
                Console.WriteLine("Error: Cannot divide by zero!");
            break;
        default:
            Console.WriteLine("Invalid choice. Please pick 1-5.");
            break;
    }
}

Console.WriteLine("Program closed. Goodbye!");