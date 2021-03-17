namespace E_03_GrandPrix.Factories
{
    using E_03_GrandPrix.Models.Cars;
    using E_03_GrandPrix.Models.Drivers;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DriverFactory
    {
        public static Driver CreateDriver(List<string> commandArgs, Car car)
        {
            string driverType = commandArgs[0];
            switch (driverType)
            {
                case "Aggressive":
                    return new AggressiveDriver(commandArgs[1], car);
                case "Endurance":
                    return new EnduranceDriver(commandArgs[1], car);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
