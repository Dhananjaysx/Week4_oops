using System;

namespace Week4_oops
{
    internal class model
    {
 
        public string model1;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public model(string modelName, string modelColor, int modelYear)
        {
            model1 = modelName;
            color = modelColor;
            year = modelYear;
        }
    }
}
