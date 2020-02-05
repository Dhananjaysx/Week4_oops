using System;

namespace Week4_oops
{
    class program
    {
        static void Main(string[] args)
        {
            car    myObj = new car();
            car myobj2 = new car(); 
            //Console.WriteLine(myObj.Color);
            Console.WriteLine("================");
            //Console.WriteLine(myobj2.Color);


            ////Class Member Call 

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

            //  Class Constructor exercise 3  and exercise 4
            model Fordm = new model("Mustang", "Red", 1969);
            Console.WriteLine(Fordm.color + " " + Fordm.year + " " + Fordm.model1);

            ///Calling properties

            Person myObj1 = new Person();
            myObj1.Name = "Liam";
            Console.WriteLine(myObj1.Name);
           
            //Inheritance
            Car myCar = new Car();
        
            myCar.honk();
                       
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

        }
    }
}
