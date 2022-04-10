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
        calcNavigation(routes[0]);

        private List<string> routes;
        private string Name;
    }
}