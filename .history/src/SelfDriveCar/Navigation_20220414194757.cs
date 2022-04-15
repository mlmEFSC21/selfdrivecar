namespace SelfDriveCar
{
    class Navigation 
    {
        public void calcNavigation(string route)
        {
            string path;
            if (route == "Work")
            {
                var car1 = new Car();
                car1.forward();
            }
            else
            {
                Console.WriteLine("Route not found");
            }
        }
    }
}