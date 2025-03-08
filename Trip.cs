using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    internal class Trip
    {
        public string Destination;
        public double Distance;
        public double GasCost;
        public double Gallons;

        public Trip(string destination, double distance, double gasCost, double gallons)
        {
            Destination = destination;
            Distance = distance;
            GasCost = gasCost;
            Gallons = gallons;
        }

        public double MilesPerGallon()
        {
            return Distance / Gallons;
        }

        public double CostPerMile()
        {
            return GasCost / Distance;
        }

        public void ShowTrip()
        {
            Console.WriteLine("Trip to " + Destination);
            Console.WriteLine("Miles per gallon: " + MilesPerGallon());
            Console.WriteLine("Cost per mile: " + CostPerMile());
        }

    }
}
