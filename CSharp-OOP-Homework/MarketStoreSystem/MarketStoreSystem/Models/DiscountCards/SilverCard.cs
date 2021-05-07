namespace MarketStoreSystem.Models.DiscountCards
{
    using Interfaces;
    using ErrorMessages;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SilverCard : IDiscountCard
    {
        public SilverCard(string firstName, string lastName, double turnoverPrevMonth)
        {
            this.Id = Guid.NewGuid().ToString();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.TurnoverPrevMonth = turnoverPrevMonth;

            if (turnoverPrevMonth < 300) this.DiscountRatePercantage = 2;
            else this.DiscountRatePercantage = 3.5;

        }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double TurnoverPrevMonth
        {
            get
            {
                return TurnoverPrevMonth;
            }
            set
            {
                bool isInvalid = value < 0;
                if (isInvalid)
                {
                    throw new ArgumentException(OutputMassages.NegativeNumber);
                }
            }
        }
        public double DiscountRatePercantage { get; set; }
    }
}
