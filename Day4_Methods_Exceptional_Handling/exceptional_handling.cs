try
{
    Console.WriteLine("Inside the try block");
    int a = 10;
    int b = 0;
    int result = a / b;  
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: " + ex.Message);  
}
