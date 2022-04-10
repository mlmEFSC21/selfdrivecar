namespace SelfDriveCar
{
    class Car 
    {
        public void startEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public void drive(name)
        {
            Console.WriteLine(Navigation.calcNavigation(name));
        }

        public void stopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}