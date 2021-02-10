﻿using OOP_Practice.Interfaces;
using System;

namespace OOP_Practice.Entities
{
    public class Ship : Transport, IRepair
    {
        public override void Move()
        {
            Console.WriteLine("Ship move");
        }

        public override void Park()
        {
            Console.WriteLine("Ship park");
        }

        public override void Refuel()
        {
            Console.WriteLine("Ship refuel");
        }

        public void Repair()
        {
            Console.WriteLine("Ship repair");
        }
    }
}