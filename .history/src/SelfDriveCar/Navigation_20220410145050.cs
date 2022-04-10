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
            Console.WriteLine("Calculating navigation to " + route.Name);
        }
        private string rightTurn = "Right turn"; 
        private string leftTurn = "Left turn"; 
        private string stopSign = "Stop (Stop Sign)"; 
        private string redLight = "Stop (Red Light)"; 
        private string speedUp = "Accelerating..."; 
    }
}