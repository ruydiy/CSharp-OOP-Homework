namespace E_03_GrandPrix.Factories
{
    using E_03_GrandPrix.Models.Cars;
    using E_03_GrandPrix.Models.Tyres;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class CarFactory
    {
        public static Car CreateCar(List<string> commandArgs, Tyre tyre)
        {
            return new Car(int.Parse(commandArgs[0]), double.Parse(commandArgs[1], tyre));
        }
    }
}
