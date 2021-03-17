namespace E_03_GrandPrix.Models.Cars
{
    using E_03_GrandPrix.Models.Tyres;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Car
    {
        private const double MAX_TANK_CAPACITY = 160.0;
        private const string FUEL_OUTPUT_ERROR = "OutOfFuel";

        private int hp;
        private double fuelAmount;
        private Tyre tyre;

        public Car (int hp, double fuelAmount, Tyre tyre)
        {
            this.Hp = hp;
            this.FuelAmount = fuelAmount;
            this.Tyre = tyre;
        }

        public Tyre Tyre
        {
            get { return this.tyre; }
            private set { this.tyre = value; }
        }
        public int Hp 
        {
            get { return this.hp; }  
            private set { this.hp = value; }
        }

        public double FuelAmount 
        {
            get { return this.fuelAmount; }
            private set
            {
                if ( value < 0)
                {
                    throw new ArgumentException(FUEL_OUTPUT_ERROR);
                }

                if ( value > MAX_TANK_CAPACITY)
                {
                    this.fuelAmount = MAX_TANK_CAPACITY;
                }
                else
                {
                    this.fuelAmount = value;
                }
            } 
        }

        public void Refuel (double litres)
        {
            this.FuelAmount += litres;
        }

        public void ChangeTyres (Tyre newTyre)
        {
            this.Tyre = newTyre;
        }

        public void ReduceFuel ( int lenght, double fuelConsumptionPerKm)
        {
            this.FuelAmount -= lenght * fuelConsumptionPerKm;
        }
    }
}
