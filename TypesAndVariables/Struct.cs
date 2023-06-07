using System;


namespace TypesAndVariables
{
    //A structure type (or struct type) is a value type that can encapsulate data and related functionality

    public struct Car
    {
        public string Name { get; set; }
        public string Model_no { get; set; }
        public int Engine_capacity { get; set; }

        public string Classification { get; set; }
    }

    public class Cars
    {
        public string Name { get; set; }
        public string Model_no { get; set; }
        public int Engine_capacity { get; set; }

        public string Classification { get; set; }
    }
    public class Struct
    {
        public void RunStruct()
        {
            Car car = new Car();
            car.Name = "bugati";
            car.Model_no = "petrol_auto";
            car.Engine_capacity = 4000;
            car.Classification = "supercar";

            Console.WriteLine(car.Name + " " + car.Model_no + " " + car.Classification);
        }
    }
}
