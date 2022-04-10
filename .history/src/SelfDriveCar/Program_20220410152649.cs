namespace SelfDriveCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var route = new Routes("Work");
            car.startEngine();
            car.drive(route);
            car.stopEngine();
        }
    }
}