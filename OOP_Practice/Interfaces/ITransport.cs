namespace OOP_Practice.Interfaces
{
    public interface ITransport
    {
        string Model { get; set; }

        int Speed { get; set; }

        int CurrentFuel { get; set; }

        void Move();

        void Park();

        void Refuel();
    }
}