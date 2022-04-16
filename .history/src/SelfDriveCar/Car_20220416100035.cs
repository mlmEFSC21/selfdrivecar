namespace SelfDriveCar
{
    class Car 
    {
        public void startEngine()
        {
            //self-explanatory
            Console.WriteLine("Car engine started");
        }
        public void stopEngine()
        {
            //self-explanatory
            Console.WriteLine("Car engine stopped ");
        }

        public void drive(string name)
        {
            var nav1 = new Navigation();
            //passes name from car.drive to nav1.calcNavigation which returns a string of the path taken. Then writes string to console.
            nav1.calcNavigation(name);
        }

        public void leftTurn() {
            //self-explanatory
            Console.WriteLine("Car left turn ");
        }
        public void rightTurn() {
            //self-explanatory
            Console.WriteLine("Car right turn ");
        }
        public void forward() {
            //self-explanatory
            Console.WriteLine("Car forward ");
        }
        public void reverse() {
            //self-explanatory
            Console.WriteLine("Car reverse ");
        }
        public void stop() {
            //self-explanatory
            Console.WriteLine("Car stop ");
        }
        public void parkCar() {
            //self-explanatory
            Console.WriteLine("Car parked ");
        }
    }
}