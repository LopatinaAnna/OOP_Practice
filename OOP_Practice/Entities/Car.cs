using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice.Entities
{
    public class Car : Transport, IRepair
    {
        public virtual void Repair() => Console.WriteLine("Car repair");
    }
}