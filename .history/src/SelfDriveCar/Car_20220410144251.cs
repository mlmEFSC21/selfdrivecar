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
            Console.WriteLine("Car is driving to " + route.destination);
        }

        public void stopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}