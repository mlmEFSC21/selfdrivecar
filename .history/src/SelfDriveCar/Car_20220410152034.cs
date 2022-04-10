namespace SelfDriveCar
{
    class Car 
    {
        public void startEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public void drive(route)
        {
            Navigation.calcNavigation(route);
        }

        public void stopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}