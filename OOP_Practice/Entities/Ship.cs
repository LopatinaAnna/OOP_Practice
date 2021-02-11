using System;

namespace OOP_Practice.Entities
{
    public class Ship : Transport
    {
        public override void Repair() => Console.WriteLine("Ship repair");
    }
}