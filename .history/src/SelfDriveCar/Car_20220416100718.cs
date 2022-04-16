namespace SelfDriveCar
{
    class Car 
    {
        public void startEngine()
        {
            Console.WriteLine("Car engine started");
        }
        public void stopEngine()
        {
            Console.WriteLine("Car engine stopped ");
        }

        public Boolean safetyCheckPassed(doorsCheck, seatBeltCheck, obstructionsCheck)
        {
            if (doorsCheck == true && seatBeltCheck == true && obstructionsCheck == true)
            {
                Console.WriteLine("Safety check passed");
                return true;
            }
            else
            {
                Console.WriteLine("Safety check failed");
                return false;
            }
        }

        public void drive(string name)
        {
            var nav1 = new Navigation();
            //passes name from car.drive to nav1.calcNavigation which returns a string of the path taken. Then writes string to console.
            nav1.calcNavigation(name);
        }

        public void leftTurn() {
            Console.WriteLine("Car left turn ");
        }
        public void rightTurn() {
            Console.WriteLine("Car right turn ");
        }
        public void forward() {
            Console.WriteLine("Car forward ");
        }
        public void reverse() {
            Console.WriteLine("Car reverse ");
        }
        public void stop() {
            Console.WriteLine("Car stop ");
        }
        public void parkCar() {
            Console.WriteLine("Car parked ");
        }
    }
}