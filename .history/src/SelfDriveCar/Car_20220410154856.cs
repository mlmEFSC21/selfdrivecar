namespace SelfDriveCar
{
    class Car 
    {
        public void startEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public void drive(string name)
        {
            Navigation.calcNavigation(name);
            Console.WriteLine();
        }

        public void stopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}