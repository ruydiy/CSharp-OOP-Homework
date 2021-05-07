namespace MarketStoreSystem.Models.DiscountCards
{
    using ErrorMessages;
    using Interfaces;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BronzeCard : IDiscountCard
    {

        public BronzeCard(string firstName, string lastName, double turnoverPrevMonth)
        {
            this.Id = Guid.NewGuid().ToString();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.TurnoverPrevMonth = turnoverPrevMonth;

            if (turnoverPrevMonth < 100) this.DiscountRatePercantage = 0;
            else if (turnoverPrevMonth < 300) this.DiscountRatePercantage = 1;
            else this.DiscountRatePercantage = 2.5;
        }
        public string Id { get ;  set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
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
