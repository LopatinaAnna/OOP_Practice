using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice.Entities
{
    public class Ship : Transport, IRepair
    {
        public void Repair() => Console.WriteLine("Ship repair");
    }
}