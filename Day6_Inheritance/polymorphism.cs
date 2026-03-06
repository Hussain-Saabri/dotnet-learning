// compile time plymorphism

class A{
    public void add()
    {
        int a = 10, b = 20;
        Console.WriteLine("Sum = " + (a+b));
    }
    public void add(int a ,int b) {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }

    public void show()
    {
        Console.WriteLine("Inside Class A");
    }
    
}
class B : A {
    public void show()
    {
      //  base.show(); class parent class
        Console.WriteLine("Inside Child Class");
    }

}
class Program {
    
    public static void Main(String[] args) {
        Console.WriteLine("Complie time polymorphism");
        A a = new A();
        a.add();
        a.add(10,20);
        Console.WriteLine("Run time polymorphism");
        B b = new B();
        b.show();
        
    }
}