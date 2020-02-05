using System;

internal interface IFirstInterface
{
    void myMethod(); 
}

internal interface ISecondInterface
{
    void myOtherMethod(); 
}

internal class DemoClass : IFirstInterface, ISecondInterface
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