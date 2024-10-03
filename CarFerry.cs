using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_7
{
    public class CarFerry
    {
        private string name;
        private double weight;
        private double maxWeight;
        private List<Vehicle> vehicels = new List<Vehicle>();

        public CarFerry(string name, double weight, double maxWeight)
        {
            this.name = name;
            this.weight = weight;
            this.maxWeight = maxWeight;
        }
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public double GetWeight()
        {
            return weight;
        }

        public double GetMaxWeight()
        {
            return maxWeight;
        }

        public void addVehicle(Vehicle vehicel)
        {
            vehicels.Add(vehicel);
        }

        public void RemoveVehicle(Vehicle vehicel)
        {
            vehicels.Remove(vehicel);
        }

        public Vehicle GetVehicel(string licenseplate)
        {
            foreach (var vehicle in vehicels)
            {
                if (vehicle.getLicensePlate() == licenseplate)
                {
                    return vehicle;
                }
            }
            return null;
        }

        public double GetTotalWeight()
        {
            double totalWeight = weight;
            foreach (var vehicle in vehicels)
            {
                totalWeight += vehicle.getWeight();
            }
            return totalWeight;
        }

        public bool IsOverWeight()
        {
            return GetTotalWeight() > maxWeight;
        }
    }
}
