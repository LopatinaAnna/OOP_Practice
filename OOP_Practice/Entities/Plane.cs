﻿using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice.Entities
{
    public class Plane : IPlane
    {
        public string Model { get; set; }

        public int Speed { get; set; }

        public int CurrentFuel { get; set; }

        public void BaggageDrop() => Console.WriteLine("Baggage drop");

        public void Move() => Console.WriteLine("Plane move");

        public void Park() => Console.WriteLine("Plane park");

        public void Refuel() => Console.WriteLine("Plane refuel");

        public void Repair() => Console.WriteLine("Plane repair");

        public override string ToString() => string.Join(' ', "Plane", Model);
    }
}