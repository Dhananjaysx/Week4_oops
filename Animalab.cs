using System;

internal abstract class Animalab
{
    public abstract void animalSound();
   public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

internal class Pigab : Animalab
{
  public override void animalSound()
  {
   
    Console.WriteLine("The pig says: wee wee");
  }
}

    

