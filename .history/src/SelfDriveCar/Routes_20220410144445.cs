namespace SelfDriveCar
{
    class Routes
    {
        public Routes(string name) 
        {
            routes = new List<string>();
            Name = name;
        }
        public calcNavigation(string destination)
        {
            Console.WriteLine("Calculating navigation to " + destination);
            
        }



        private List<string> routes;
        private string Name;
    }
}