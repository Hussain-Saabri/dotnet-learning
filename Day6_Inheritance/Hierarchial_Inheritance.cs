using System;

// Base class
class A
{
    public int a = 10, b = 20;

    public void add()
    {
        Console.WriteLine("Sum = " + (a + b));
    }
}

// Derived class 1
class B : A
{
    public void sub()
    {
        Console.WriteLine("Difference = " + (a - b));
    }
}

// Derived class 2
class C : A
{
    public void mul()
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hierarchical Inheritance");

        B obj1 = new B();
        obj1.add();   
        obj1.sub();   

        C obj2 = new C();
        obj2.add();  
        obj2.mul();   
    }
}