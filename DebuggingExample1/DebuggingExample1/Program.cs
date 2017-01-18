using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;

            car = new Car("Blue");
            Console.WriteLine(car.Describe());

            car = new Car("Red");
            Console.WriteLine(car.Describe());

            Car [] cars = new Car[10];
            cars[0] = car;
            cars[1] = new Car("Orange");
            cars[2] = new Car("Red");
            cars[3] = new Car("Blue");
            cars[4] = new Car("Grey");
            cars[5] = new Car("Green");
            cars[6] = new Car("Black");
            cars[7] = new Car("White");
            cars[8] = new Car("Blue");
            cars[8] = new Car("Red");
            cars[9] = new Car("Green");


            for (int i = 0; i <= cars.Length; i++)
            {
                Console.WriteLine(cars[i].Describe());
            }

            Console.ReadKey();
        }
    }

    class Car
    {
        private string color;

        public Car(string color)
        {
            this.color = color;
        }

        public string Describe()
        {
            return "This car is " + Color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
