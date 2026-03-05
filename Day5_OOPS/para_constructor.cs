using System;
//Default constructor
Car myCar = new Car("Toyota");

public class Car
{
    public Car(string brand)
    {
        Console.WriteLine($"Car object created!");
    }
}