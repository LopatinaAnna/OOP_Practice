using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice.Entities
{
    public class Plane : Transport, IRepair
    {
        public override void Move()
        {
            Console.WriteLine("Plane move");
        }

        public override void Park()
        {
            Console.WriteLine("Plane park");
        }

        public override void Refuel()
        {
            Console.WriteLine("Plane refuel");
        }

        public void Repair()
        {
            Console.WriteLine("Plane repair");
        }
    }
}