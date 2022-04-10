namespace SelfDriveCar
{
    class Navigation 
    {
        public string calcNavigation(string route)
        {
            string path;
            if (route.Name == "Work")
        {
            return path = $"{rightTurn}, {stopSign}, {leftTurn}, {stopSign}";
        }
        else
        {
            Console.WriteLine("Unknown route");
        }
        }
        
        private string rightTurn = "Right turn"; 
        private string leftTurn = "Left turn"; 
        private string stopSign = "Stop (Stop Sign)"; 
        private string redLight = "Stop (Red Light)"; 
        private string speedUp = "Accelerating..."; 
        private string slowDown = "Decelerating...";
        private string parkCar = "Parking...";
    }
}