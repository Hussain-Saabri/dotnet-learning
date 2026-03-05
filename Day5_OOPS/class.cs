using System;


Car myCar = new Car();
myCar.Brand = "Toyota";
myCar.Drive();


public class Car
{
    public string Brand { get; set; }
    
    public void Drive()
    {
        Console.WriteLine($"{Brand} is moving!");
    }
}