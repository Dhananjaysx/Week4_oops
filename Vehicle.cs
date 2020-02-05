using System;

internal class Vehicle
    {

    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

internal class Car : Vehicle
{
    public string modelName = "Mustang";  // Car field
}




