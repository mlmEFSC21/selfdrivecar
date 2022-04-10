namespace SelfDriveCar
{
    class Navigation 
    {
        public string calcNavigation(string route)
        {
            if (route.Name == "Work")
        {
            return string path = $"{rightTurn}, {stopSign}, {leftTurn}}";
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