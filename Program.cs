using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trip trip = new Trip("New York", 300, 50, 15);
            trip.ShowTrip();

        }
    }
}
