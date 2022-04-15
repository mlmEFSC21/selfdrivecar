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
                car1.reverse();
                car1.forward();
                car1.stop();
                car1.rightTurn();
                car1.forward();
                car1.stop();
                car1.leftTurn();
                car1.forward();
                car1.stop();
                car1.rightTurn();
                car1.forward();
                car1.stop();
                car1.rightTurn();
                car1.forward();
                car1.leftTurn();
                car1.rightTurn();
                car1.forward();
                car1.stop();
                car1.leftTurn();
                car1.forward();
                car1.stop();
                car1.rightTurn();
                car1.parkCar();

            }
            else
            {
                Console.WriteLine("Route not found");
            }
        }
    }
}