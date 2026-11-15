namespace BMICalculatorApp.Models
{
    public class BMI
    {
        // Define properties (get/set)
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Result { get; set; }

        // Define calculation method
        public void CalculateBMI()
        {
            if (Height > 0)
            {
                // If height entered in cm (e.g., 150), convert to meters (1.50)
                double h = Height > 3 ? Height / 100.0 : Height;
                Result = Weight / (h * h);
            }
        }
    }
}
