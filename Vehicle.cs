using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_7
{
    public class Vehicle
    {
        private String licensePlate;
        private double weight;

        public String getLicensePlate()
        {
            return licensePlate;
        }

        public double getWeight()
        {
            return weight;
        }

        public Vehicle(String licensePlate, double weight)
        {
            this.licensePlate = licensePlate;
            this.weight = weight;
        }

        public override string ToString()
        {
            return "bil [Nummerplade: " + licensePlate + " vægt: " + weight + "]";
        }

        public bool Equals(Vehicle other)
        {
            if (other == null) return false;
            return this.licensePlate == other.licensePlate;
        }
    }
}



