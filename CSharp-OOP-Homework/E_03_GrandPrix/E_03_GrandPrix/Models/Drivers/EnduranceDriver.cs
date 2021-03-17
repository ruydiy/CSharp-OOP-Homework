using E_03_GrandPrix.Models.Cars;

namespace E_03_GrandPrix.Models.Drivers
{
    public class EnduranceDriver : Driver
    {
        private const double EnduranceDriverFuelConsumption = 1.5;

        public EnduranceDriver (string name, Car car)
            : base(name,car, EnduranceDriverFuelConsumption)
        {
        }
    }
    
}
