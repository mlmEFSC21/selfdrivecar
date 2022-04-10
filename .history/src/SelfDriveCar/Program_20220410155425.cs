namespace SelfDriveCar
{
    class Program
    {
        static void Main(string[] args)
        {
            //new car object
            var car = new Car();
            //new route object named Work
            var route = new Routes("Work");
            car.startEngine();
            //passes name to car which calls calcNavigation from Navigation class. Might need be unnecessary steps
            car.drive(route.Name);
            car.stopEngine();
        }
    }
}