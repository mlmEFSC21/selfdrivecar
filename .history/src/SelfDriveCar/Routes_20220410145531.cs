namespace SelfDriveCar
{
    class Routes
    {
        public Routes(string name) 
        {
            routes = new List<string>();
            Name = name;
        }

        private List<string> routes;
        private string Name;
    }
}