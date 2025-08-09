using System;

namespace MovableApp
{
    // Interface definition
    public interface IMovable
    {
        void Move();
    }

    // Car class implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Bicycle class implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Car
            IMovable car = new Car();
            car.Move();

            // Create a Bicycle
            IMovable bicycle = new Bicycle();
            bicycle.Move();
        }
    }
}

