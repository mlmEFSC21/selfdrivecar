namespace SelfDriveCar
{
    class Routes
    {
        public string Name { get; set; }
        public Routes(string name) 
        {
            //collection of all route names. Might be useless in current iteration as name could just be passed directly.
            routes = new List<string>();
            Name = name;
            routes.Add(Name);
        }
        private List<string> routes;
        
    }
}