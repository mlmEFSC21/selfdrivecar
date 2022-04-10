namespace SelfDriveCar
{
    class Routes
    {
        public string Name { get; set; }
        public Routes(string name) 
        {
            routes = new List<string>();
            Name = name;
            routes.Add(Name);
        }
        private List<string> routes;
        
    }
}