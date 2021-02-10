using OOP_Practice.Entities;

namespace OOP_Practice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Transport transport = new Transport();
            transport.Move();

            Plane plane = new Plane();
            plane.Repair();

            Transport car = new Car();
            car.Park();
        }
    }
}