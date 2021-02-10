using OOP_Practice.Entities;
using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Plane plane = new Plane();
            plane.Move();

            ICar car = new Car() { Model = "BMW X5" };
            Console.WriteLine(car.ToString());
            car.Park();
            car.Repair();

            ITransport ship = new Ship();
            ship.Refuel();

            var transports = new ITransport[]
            {
                new Car(),
                new Ship(),
                new Truck()
            };

            MoveAllTransport(transports);
        }

        private static void MoveAllTransport(ITransport[] transports)
        {
            Console.WriteLine("Move all transports:");

            foreach (var item in transports)
            {
                item.Move();
            }
        }
    }
}