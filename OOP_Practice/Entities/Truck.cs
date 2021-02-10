using System;

namespace OOP_Practice.Entities
{
    public class Truck : Transport
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

        public override void Repair()
        {
            Console.WriteLine("Truck repair");
        }
    }
}