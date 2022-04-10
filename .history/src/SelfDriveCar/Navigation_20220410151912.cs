namespace SelfDriveCar
{
    class Navigation 
    {
        public string calcNavigation(string route)
        {
            string path;
            if (route == "Work")
            {
                path = $"{rightTurn}, {stopSign}, {leftTurn}, {stopSign}, {rightTurn}, {stopSign}, {rightTurn}, {leftTurn}, {rightTurn}, {stopSign}, {leftTurn}, {redLight}, {rightTurn}, {redLight}, {leftTurn}, {redLight}, {rightTurn}, {leftTurn}";
                return path;
            }
            else
            {
                path = "Unknown route";
                return path;
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