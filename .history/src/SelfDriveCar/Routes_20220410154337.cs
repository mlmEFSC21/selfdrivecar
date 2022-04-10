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
        public string Name { get; set; }
        private List<string> routes;
        private string Name;
    }
}