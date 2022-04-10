namespace SelfDriveCar
{
    class Car 
    {
        public void startEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public void drive(Routes route)
        {
            Console.WriteLine(Navigation.calcNavigation(route.Name));
        }

        public void stopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}