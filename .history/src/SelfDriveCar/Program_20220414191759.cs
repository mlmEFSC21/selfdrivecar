namespace SelfDriveCar
{
    class Program
    {
        public void Work()
        {
            Console.WriteLine("Work");
        }
            static void Home()
            {
                Console.WriteLine("Home");
            }
            static void School()
            {
                Console.WriteLine("School");
            }
        static void Main(string[] args)
        {
            //new car object
            // var car = new Car();
            // //new route object named Work
            // var route = new Routes("Work");
            // car.startEngine();
            // //passes name to car which calls calcNavigation from Navigation class. Might need be unnecessary steps
            // car.drive(route.Name);
            // car.stopEngine();
            string[] methodNames = { "Work", "Home", "School", "Other" };

            

            String methodCall = this.GetType().GetMethod(methodNames[0]).Invoke(this, null).ToString();
        }
    }
}