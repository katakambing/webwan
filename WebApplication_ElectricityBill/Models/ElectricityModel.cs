namespace WebApplication_ElectricityBill.Models
{
    public class ElectricityModel
    {
        public double UnitsConsumed { get; set; }
        public string Category { get; set; } // e.g., Domestic / Commercial
        public double TotalAmount { get; set; }

        public void CalculateBill()
        {
            // Example electricity tariff tier calculation logic
            double rate = 0.0;

            if (Category == "Commercial")
            {
                rate = 0.50; // Flat or base rate for commercial
            }
            else // Domestic / Residential
            {
                if (UnitsConsumed <= 200)
                {
                    rate = 0.218;
                }
                else if (UnitsConsumed <= 300)
                {
                    rate = 0.334;
                }
                else
                {
                    rate = 0.516;
                }
            }

            TotalAmount = UnitsConsumed * rate;
        }
    }
}
