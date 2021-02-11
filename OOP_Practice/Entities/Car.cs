using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice.Entities
{
    public class Car : ICar
    {
        public string Model { get; set; }

        public int Speed { get; set; }

        public int CurrentFuel { get; set; }

        public virtual void Move() => Console.WriteLine("Car move");

        public virtual void Park() => Console.WriteLine("Car park");

        public virtual void Refuel() => Console.WriteLine("Car refuel");

        public virtual void Repair() => Console.WriteLine("Car repair");

        public override string ToString() => string.Join(' ', "Car", Model);
    }
}