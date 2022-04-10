namespace SelfDriveCar
{
    class Car 
    {
        public void startEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public void drive(routeName)
        {
            routeName = routes[0].Name;
            Navigation.calcNavigation(routeName);
        }

        public void stopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}