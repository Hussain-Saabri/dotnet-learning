//An interface cannot contain method bodies (only declarations).

//A class implements an interface using the : symbol.

//A class must implement all methods of the interface.

//Interfaces support multiple inheritance.

//Interface methods are public by default.

interface IAnimal
{
    void sound();
}

class Dog : IAnimal
{
    public void sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        d.sound();
    }
}