namespace SelfDriveCar
{
    class Program
    {
        static void Main(string[] args)
        {
            car = new Car();
            route = new Routes("Work");
            car.startEngine();
            car.drive(route);
            car.stopEngine();
        }
    }
}