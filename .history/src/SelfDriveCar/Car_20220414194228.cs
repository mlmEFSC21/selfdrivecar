namespace SelfDriveCar
{
    class Car 
    {
        public void startEngine()
        {
            //self-explanatory
            Console.WriteLine("Car engine started");
        }

        public void drive(string name)
        {
            var nav1 = new Navigation();
            //passes name from car.drive to nav1.calcNavigation which returns a string of the path taken. Then writes string to console.
            nav1.calcNavigation(name);
        }

        public void stopEngine()
        {
            //self-explanatory
            Console.WriteLine("Car engine stopped");
        }
    }
}