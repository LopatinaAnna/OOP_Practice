using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice.Entities
{
    public class Plane : Transport, IRepair
    {
        public void BaggageDrop() => Console.WriteLine("Baggage drop");

        public void Repair() => Console.WriteLine("Plane repair");
    }
}