using System;

namespace OOP_Practice.Entities
{
    public class Transport
    {
        public int Speed { get; set; }

        public virtual void Move()
        {
            Console.WriteLine("Transport move");
        }

        public virtual void Park()
        {
            Console.WriteLine("Transport park");
        }

        public virtual void Refuel()
        {
            Console.WriteLine("Transport refuel");
        }
    }
}