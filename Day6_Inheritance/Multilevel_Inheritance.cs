using System;

// Base Class
class A
{
    public int a = 10, b = 20;

    public void add()
    {
        Console.WriteLine("Sum = " + (a + b));
    }
}

// Derived Class from A
class B : A
{
    public void sub()
    {
        Console.WriteLine("Difference = " + (a - b));
    }
}

// Derived Class from B
class C : B
{
    public void mul()
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Multilevel Inheritance");

        C obj = new C();

        obj.add();  // from class A
        obj.sub();  // from class B
        obj.mul();  // from class C
    }
}