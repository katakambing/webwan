namespace WebApplication_Lab1_Wan.Models
{
    public class ElectricityModel
    {
        public double previousReading { get; set; }
        public double currentReading { get; set; }
        public double usage { get; set; }
        public double chargeBlock1 { get; set; }
        public double chargeBlock2 { get; set; }
        public double chargeBlock3 { get; set; }
        public double usageBlock1 { get; set; }
        public double usageBlock2 { get; set; }
        public double usageBlock3 { get; set; }
        public double totalCharge { get; set; }

        public void CalculateUsage()
        {
            usage = currentReading - previousReading;

            if (usage <= 300)
            {
                usageBlock1 = usage;
                chargeBlock1 = usage * 0.30;
                totalCharge = chargeBlock1;
            }
            else if (300 < usage && usage <= 700)
            {
                usageBlock1 = 300;
                usageBlock2 = usage - 300;
                chargeBlock1 = 300 * 0.30;
                chargeBlock2 = (usage - 300) * 0.40;
                totalCharge = chargeBlock1 + chargeBlock2;
            }
            else if (usage > 700)
            {
                usageBlock1 = 300;
                usageBlock2 = 400;
                usageBlock3 = usage - 700;
                chargeBlock1 = 300 * 0.30;
                chargeBlock2 = 400 * 0.40;
                chargeBlock3 = (usage - 700) * 0.50;
                totalCharge = chargeBlock1 + chargeBlock2 + chargeBlock3;
            }
        }
    }
}
