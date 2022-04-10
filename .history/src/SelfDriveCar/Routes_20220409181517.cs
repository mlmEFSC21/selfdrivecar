namespace SelfDriveCar
{
    class Route
    {
        public Route(string name) 
        {
            routes = new List<string>();
            Name = name;
        }

        private List<string> routes;
        private string Name;
    }
}