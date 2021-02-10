using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice.Entities
{
    public class Car : Transport, IRepair
    {
        public override void Move()
        {
            Console.WriteLine("Car move");
        }

        public override void Park()
        {
            Console.WriteLine("Car park");
        }

        public override void Refuel()
        {
            Console.WriteLine("Car refuel");
        }

        public void Repair()
        {
            Console.WriteLine("Car repair");
        }
    }
}