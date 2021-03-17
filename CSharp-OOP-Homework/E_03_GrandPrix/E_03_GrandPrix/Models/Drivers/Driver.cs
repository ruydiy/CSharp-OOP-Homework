namespace E_03_GrandPrix.Models.Drivers
{
    using E_03_GrandPrix.Models.Cars;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public abstract class Driver
    {
        private string name;
        private double totalTime;
        private Car car;
        private double fuelConsumptionPerKm;
        //private double speed;

        protected Driver (string name, Car car, double FuelConsumptionPerKm)
        {
            this.Name = name;
            this.Car = car;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }
        public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;

        public string Name 
        {
            get { return this.name; }
            private set { this.name = value; } 
        }
        public double TotalTime 
        {
            get { return this.totalTime; }
            private set { this.totalTime = value; } 
        }
        public double FuelConsumptionPerKm 
        {
            get { return this.fuelConsumptionPerKm; }
            private set { this.fuelConsumptionPerKm = value; } 
        }
        public Car Car
        {
            get { return this.car; }
            private set { this.car = value; }
        }
        public void ReduceFuelAmount (int lenght)
        {
            this.Car.ReduceFuel(lenght, this.FuelConsumptionPerKm);
        }

    }
}
