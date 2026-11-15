namespace WebApplication_TempConverter.Models
{
    public class TempModel
    {
        public double Temperature { get; set; }
        public double Result { get; set; }
        public string ConversionType { get; set; }

        public void ConvertTemperature()
        {
            if (ConversionType == "FtoC")
            {
                // Fahrenheit to Celsius
                Result = (Temperature - 32) * 5 / 9;
            }
            else if (ConversionType == "CtoF")
            {
                // Celsius to Fahrenheit
                Result = (Temperature * 9 / 5) + 32;
            }
        }
    }
}
