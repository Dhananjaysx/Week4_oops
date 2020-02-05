using System;
interface IFirstInterface
{
    void myMethod(); 
}

interface ISecondInterface
{
    void myOtherMethod(); 
}

class DemoClass : IFirstInterface, ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("Calling Interface Method");
    }
    public void myOtherMethod()
    {
        Console.WriteLine("Calling Second Interface");
    }
}