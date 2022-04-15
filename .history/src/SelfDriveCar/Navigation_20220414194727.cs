namespace SelfDriveCar
{
    class Navigation 
    {
        public void calcNavigation(string route)
        {
            string path;
            if (route == "Work")
            {
                car1 = new Car();
                Car.forward();
            }
            else
            {
                Console.WriteLine("Route not found");
            }
        }
    }
}