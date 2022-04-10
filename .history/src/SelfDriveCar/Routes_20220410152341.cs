namespace SelfDriveCar
{
    class Routes
    {
        public Routes(string name) 
        {
            routes = new List<string>();
            Name = name;
            routes.Add(Name);
        }

        private List<string> routes;
        private string Name;
    }
}