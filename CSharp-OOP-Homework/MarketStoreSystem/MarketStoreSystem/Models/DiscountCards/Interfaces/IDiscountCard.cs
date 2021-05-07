namespace MarketStoreSystem.Models.DiscountCards.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDiscountCard
    {
        public string Id { get;  set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double TurnoverPrevMonth { get; set; }
        public double DiscountRatePercantage { get; set; }
    }
}
