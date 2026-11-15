namespace WebApplication_BMI_Calculator.Models
{
    public class BMIModel
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Result { get; set; }

        public void CalculateBMI()
        {
            if (Height > 0)
            {
                Result = Weight / (Height * Height);
            }
        }
    }
}
