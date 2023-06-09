using System;
using System.Runtime.ConstrainedExecution;

namespace MyApplication
{
    class Car
    {
        public string color = "red";// public là truy cập công khai
    }
    // private là truy cập riêng tư
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();// Car() là hàm tạo
            Console.WriteLine(myObj.color);
        }
    }
}

using System;

namespace MyApplication
{
    class Car
    {
        public string model;// đây được gọi là 1 trường
        public string color;
        public int year;

        
        public Car(string modelName, string modelColor, int modelYear)// đây là 1 hàm có tham số
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
        }
    }
}
