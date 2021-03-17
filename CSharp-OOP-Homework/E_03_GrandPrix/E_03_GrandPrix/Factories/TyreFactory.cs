namespace E_03_GrandPrix.Factories
{
    using E_03_GrandPrix.Models.Tyres;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TyreFactory
    {
        public static Tyre CreateTyre(List<string> commandArgs)
        {
            string tyreType = commandArgs[0];
            switch (tyreType)
            {
                case "Hard":
                    return new HardTyre(double.Parse(commandArgs[1]));
                case "Ultrasoft":
                    return new UltrasoftTyre(double.Parse(commandArgs[1]), double.Parse(commandArgs[2]));
                default:
                    throw new ArgumentException();
            }
        }
    }
}
