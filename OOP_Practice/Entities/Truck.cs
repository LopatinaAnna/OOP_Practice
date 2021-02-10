using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice.Entities
{
    public class Truck : ICar
    {
        public void Move()
        {
            Console.WriteLine("Truck move");
        }

        public void Park()
        {
            Console.WriteLine("Truck park");
        }

        public void Refuel()
        {
            Console.WriteLine("Truck refuel");
        }

        public void Repair()
        {
            Console.WriteLine("Truck repair");
        }
    }
}