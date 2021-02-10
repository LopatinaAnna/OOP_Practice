using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice.Entities
{
    public class Truck : Transport, IRepair
    {
        public override void Move()
        {
            Console.WriteLine("Truck move");
        }

        public override void Park()
        {
            Console.WriteLine("Truck park");
        }

        public override void Refuel()
        {
            Console.WriteLine("Truck refuel");
        }

        public void Repair()
        {
            Console.WriteLine("Truck repair");
        }
    }
}