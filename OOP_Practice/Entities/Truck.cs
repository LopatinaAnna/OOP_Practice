﻿namespace OOP_Practice.Entities
{
    public class Truck : Car
    {
        public override string ToString() => string.Join(' ', "Truck", Model);
    }
}