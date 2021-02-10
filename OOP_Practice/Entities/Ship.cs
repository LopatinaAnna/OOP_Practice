using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice.Entities
{
    public class Ship : IShip
    {
        public void Move()
        {
            Console.WriteLine("Ship move");
        }

        public void Park()
        {
            Console.WriteLine("Ship park");
        }

        public void Refuel()
        {
            Console.WriteLine("Ship refuel");
        }

        public void Repair()
        {
            Console.WriteLine("Ship repair");
        }
    }
}