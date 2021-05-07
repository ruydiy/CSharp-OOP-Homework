namespace MarketStoreSystem
{
    using MarketStoreSystem.Models.DiscountCards.Interfaces;
    using Models.DiscountCards;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PayDesk
    {
        public static void PrintInfo(string card, double purchaseValue, double turnover)
        {
            double discount = 0, total = 0, discountRate = 0;
            switch (card)
            {
                case "Bronze":
                    BronzeCard bronzeCard = new BronzeCard();
                    discountRate = bronzeCard.DiscountRatePercantage;
                    discount = bronzeCard.DiscountRatePercantage * purchaseValue / 100;
                    total = purchaseValue - discount;
                    break;
                case "Silver":
                    SilverCard silverCard = new SilverCard();
                    discountRate = silverCard.DiscountRatePercantage;
                    discount = silverCard.DiscountRatePercantage * purchaseValue / 100;
                    total = purchaseValue - discount;
                    break;
                case "Gold":
                    GoldCard goldCard = new GoldCard();
                    discountRate = goldCard.DiscountRatePercantage;
                    discount = goldCard.DiscountRatePercantage * purchaseValue / 100;
                    total = purchaseValue - discount;
                    break;
            }
            Console.WriteLine($"Purchase value: ${purchaseValue:F2}");
            Console.WriteLine($"Discount rate: {discountRate:F1}%");
            Console.WriteLine($"Discount: ${discount:F2}");
            Console.WriteLine($"Total: ${total:F2}");
        }

    }
}
