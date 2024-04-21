using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8Exercitii
{
    internal class FreightWagon : Wagon
    {
        public string CargoType { get; set; }
        public int CapacityInTons { get; set; }
        public int YearOfManufacture { get; set; }
        public int Weight { get; set; }

        public FreightWagon(int weight, int yearOfManufacture, string cargoType, int capacityInTons)
            : base(weight, yearOfManufacture)
        {
            CargoType = cargoType;
            CapacityInTons = capacityInTons;
            YearOfManufacture = yearOfManufacture;
            Weight = weight;
        }
    }
}
