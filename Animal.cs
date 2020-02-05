using System;

internal class Animal  
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

internal class Pig : Animal  
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

internal class Dog : Animal  
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }



