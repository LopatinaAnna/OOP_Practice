﻿using System;

namespace OOP_Practice.Entities
{
    public class Car : Transport
    {
        public override void Repair() => Console.WriteLine("Car repair");
    }
}