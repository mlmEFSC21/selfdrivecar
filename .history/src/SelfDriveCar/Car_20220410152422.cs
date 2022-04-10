namespace SelfDriveCar
{
    class Car 
    {
        public void startEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public void drive(routes[0])
        {
            Navigation.calcNavigation(routes[0]);
        }

        public void stopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}