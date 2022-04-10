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
            Navigation.calcNavigation();
            Console.WriteLine();
        }

        public void stopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}