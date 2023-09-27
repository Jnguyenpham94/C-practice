using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            // polymorphism = Greek word that means to "have many forms"
            //                Objects can be identified by more than one type
            //                Ex. A Dog is also: Canine, Animal, Organism

            Car car = new Car(4, "steel");
            Bicycle bicycle = new Bicycle("aluminum");
            Boat boat = new Boat("carbon fiber");

            Vehicle[] vehicles = { car, bicycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
                vehicle.Details();
            }

        }
    }
    class Vehicle
    {
        private int wheels { get; set; }
        private string frame { get; set; }

        public Vehicle(int wheels, string frame)
        {
            this.wheels = wheels;
            this.frame = frame;
        }


        public virtual void Go()
        {

        }

        public virtual void Details()
        {
            Console.WriteLine($"wheels: {wheels} | frame: {frame}");
        }
    }
    class Car : Vehicle
    {

        public Car(int wheels, string frame) : base(wheels, frame)
        {
        }

        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }

        public override void Details()
        {
            base.Details();
        }
    }
    class Bicycle : Vehicle
    {
        public Bicycle(string frame, int wheels = 2) : base(wheels, frame)
        {
        }

        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }

        public override void Details()
        {
            base.Details();
        }
    }
    class Boat : Vehicle
    {
        public Boat(string frame, int wheels = 0) : base(wheels, frame)
        {
            
        }

        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }

        public override void Details()
        {
            base.Details();
        }
    }
}