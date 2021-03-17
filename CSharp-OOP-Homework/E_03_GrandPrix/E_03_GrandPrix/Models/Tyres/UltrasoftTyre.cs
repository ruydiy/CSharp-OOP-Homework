namespace E_03_GrandPrix.Models.Tyres
{
    using System;
    public class UltrasoftTyre : Tyre
    {
        private const string TYRE_OUTPUT_ERROR = "BlownTyre";

        private double grip;
        private double degradation;

        public UltrasoftTyre(double hardness, double grip)
            :base ("Ultrasoft", hardness)
        {
            this.Grip = grip;
        }

        public double Grip 
        {
            get { return this.grip; }
            private set { this.grip = value; }
        }

        public override double Degradation 
        {
            get { return this.degradation; } 
            protected set
            {
                if (value < 30)
                {
                    throw new ArgumentException(TYRE_OUTPUT_ERROR);
                }
                this.degradation = value;
            } 
        }

        public override void ReduceDegradation()
        {
            this.Degradation -= this.Hardness + this.Grip;
        }
    }
}
