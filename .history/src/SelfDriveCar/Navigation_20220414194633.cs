namespace SelfDriveCar
{
    class Navigation 
    {
        public void calcNavigation(string route)
        {
            string path;
            if (route == "Work")
            {
                car.forward();
            }
            else
            {
                Console.WriteLine("Route not found");
            }
        }
    }
}