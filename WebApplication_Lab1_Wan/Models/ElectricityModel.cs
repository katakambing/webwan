namespace WebApplication_Lab1_Wan.Models
{
    public class ElectricityModel
    {
        public double UnitsConsumed { get; set; }
        public string Category { get; set; } = "Domestic";
        public double TotalAmount { get; set; }

        public void CalculateBill()
        {
            double rate = 0.0;

            if (Category == "Commercial")
            {
                rate = 0.50;
            }
            else
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
