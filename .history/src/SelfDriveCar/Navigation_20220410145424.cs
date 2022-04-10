namespace SelfDriveCar
{
    class Navigation 
    {
        if (route.Name == "Work")
        {
            var path = "Right turn";
        }
        else
        {
            Console.WriteLine("Unknown route");
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