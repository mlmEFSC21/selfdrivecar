namespace SelfDriveCar
{
    class Program
    {
        static string[] methodNames = { "Work", "Home", "School", "Other" };
        MethodInfo methodCall = this.GetType().GetMethod(methodNames[0]).Invoke(this, null).ToString();
        public void Work()
        {
            Console.WriteLine("Work");
        }
        public void Home()
        {
            Console.WriteLine("Home");
        }
        public void School()
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
            

            

            
        }
    }
}