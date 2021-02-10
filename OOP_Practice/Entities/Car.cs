using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice.Entities
{
    public class Car : ICar
    {
        public void Move()
        {
            Console.WriteLine("Car move");
        }

        public void Park()
        {
            Console.WriteLine("Car park");
        }

        public void Refuel()
        {
            Console.WriteLine("Car refuel");
        }

        public void Repair()
        {
            Console.WriteLine("Car repair");
        }
    }
}