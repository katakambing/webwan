namespace WebApplication_Lab1_Wan.Models
{
    public class TempModel
    {
        public double Temperature { get; set; }
        public double Result { get; set; }
        public string ConversionType { get; set; } = "CtoF";

        public void ConvertTemperature()
        {
            if (ConversionType == "FtoC")
            {
                Result = (Temperature - 32) * 5 / 9;
            }
            else if (ConversionType == "CtoF")
            {
                Result = (Temperature * 9 / 5) + 32;
            }
        }
    }
}
