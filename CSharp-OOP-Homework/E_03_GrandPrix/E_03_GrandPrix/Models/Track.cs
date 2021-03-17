namespace E_03_GrandPrix.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Track
    {
        public Track(int toralLaps, int lenght)
        {
            this.TotalLaps = toralLaps;
            this.Length = length;
            this.CurrentLap = 0;
            this.Weather = "Sunny";
        }
    }

    public int TotalLaps { get; }
    public int Lenght { get; }
    public int CurrentLap { get; set; }
    public string Weather { get; set; }
}
