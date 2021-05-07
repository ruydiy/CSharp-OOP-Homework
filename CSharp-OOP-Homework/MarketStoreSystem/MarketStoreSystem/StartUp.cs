namespace MarketStoreSystem
{
    using Controllers;

    using System;
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] cardValue = input.Split(": Mock data: turnover $");
            string[] purchaseValue = cardValue[1].Split(", purchase value $");
            string[] turnoverValue = new string[] { cardValue[0], purchaseValue[0], purchaseValue[1] };
            PayDesk.PrintInfo(turnoverValue[0], Convert.ToDouble(turnoverValue[2]), Convert.ToDouble(turnoverValue[1]));
        }
    }
}
