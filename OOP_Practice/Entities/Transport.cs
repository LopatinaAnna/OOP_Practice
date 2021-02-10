using System;

namespace OOP_Practice.Entities
{
    public abstract class Transport
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

        public abstract void Repair();
    }
}