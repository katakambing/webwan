namespace WebApplication_Lab1_Wan.Models
{
    public class TempModel
    {
        public double Celsius { get; set; }
        public double Fahrenheit { get; set; }
        public string Status { get; set; } = "";
        public string Color { get; set; } = "";

        public void CalculateTemperature()
        {
            Fahrenheit = (Celsius * 9 / 5) + 32;

            if (Celsius < 35)
            {
                Status = "Low body temperature";
                Color = "Blue";
            }
            else if (Celsius > 37)
            {
                Status = "You have fever!";
                Color = "Red";
            }
            else
            {
                Status = "Normal body temperature";
                Color = "Green";
            }
        }
    }
}
