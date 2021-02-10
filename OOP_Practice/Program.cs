using OOP_Practice.Entities;
using System;

namespace OOP_Practice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Plane plane = new Plane();
            plane.Move();

            Transport car = new Car();
            car.Park();
            car.Repair();

            var transports = new Transport[]
            {
                new Car(),
                new Ship(),
                new Truck()
            };

            MoveAllTransport(transports);
        }

        private static void MoveAllTransport(Transport[] transports)
        {
            Console.WriteLine("Move all transports:");

            foreach (var item in transports)
            {
                item.Move();
            }
        }
    }
}