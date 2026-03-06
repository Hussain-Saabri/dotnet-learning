
class B {
   public int a = 10, b = 20;
    public void add()
    {
        Console.WriteLine("Sum = " + (a + b));
    }
    public void sub(){
        Console.WriteLine("Difference = " + (a-b));
    }
}
class A:B {

    

    static void Main(String[] args)
{
    Console.WriteLine("Single Inheritance");
    A obj = new A();
    obj.add();
    obj.sub();
    obj.mul();
}

}
