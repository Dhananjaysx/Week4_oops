using System;

namespace Week4_oops
{
    internal class program
    {
        private static void Main(string[] args)
        {
            car    myObj = new car();
            car myobj2 = new car(); 
            //Console.WriteLine(myObj.color);
            Console.WriteLine("================");
            //Console.WriteLine(myobj2.Color);


            ////Class Member Call 
            Console.WriteLine("Exercise 2");
            Console.WriteLine("==================");
            exercise2_classmember Ford = new exercise2_classmember();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            exercise2_classmember Opel = new exercise2_classmember();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            Console.WriteLine("==========================================");

            Console.WriteLine("Class Constructor exercise 3  and exercise 4");
            Console.WriteLine("==========================================");
             model Fordm = new model("Mustang", "Red", 1969);
            Console.WriteLine(Fordm.color + " " + Fordm.year + " " + Fordm.model1);
            Console.WriteLine("==========================================");

            ///Calling properties

            Console.WriteLine("Properties Calling");
            Console.WriteLine("==========================================");

            Person myObj1 = new Person();
            myObj1.Name = "Liam";
            Console.WriteLine(myObj1.Name);

            Console.WriteLine("=================");

            //Inheritance

            Console.WriteLine("Inheritance");
            Console.WriteLine("=================");
            Car myCar = new Car();
        
            myCar.honk();
                       
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            Console.WriteLine("===================");

            //Polymorphism

            Console.WriteLine("Calling Polymorphism");
            Console.WriteLine("====================");

            Animal myAnimal = new Animal();  
            Animal myPig = new Pig();  
            Animal myDog = new Dog(); 

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
            Console.WriteLine("===============");

            //Abstract
            Console.WriteLine("Calling Abstract");
            Console.WriteLine("===============");
            Pigab Pig = new Pigab(); 
            Pig.animalSound();  
            Pig.sleep();
            Console.WriteLine("==================");
            //Interface
            DemoClass demo = new DemoClass();
            demo.myMethod();
            demo.myOtherMethod();

            /// Calling Enum 
            Console.WriteLine("=====================");
            Level myVar = Level.Medium;
            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;

            }

        }
    }
}
