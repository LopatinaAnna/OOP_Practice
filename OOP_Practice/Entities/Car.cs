using System;

namespace OOP_Practice.Entities
{
    public class Car : Transport
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

        public override void Repair()
        {
            Console.WriteLine("Car repair");
        }
    }
}