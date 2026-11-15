namespace WebApplication_Lab1_Wan.Models
{
    public class BMI
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Result { get; set; }

        public void CalculateBMI()
        {
            if (Height > 0)
            {
                double h = Height > 3 ? Height / 100.0 : Height;
                Result = Weight / (h * h);
            }
        }
    }
}
