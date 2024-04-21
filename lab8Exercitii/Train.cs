using System;
using System.Collections.Generic;
using static lab8Exercitii.Wagon;

namespace lab8Exercitii
{
    public class Train
    {
        private string name;
        private Locomotive locomotive;
        private List<Wagon> wagons = new List<Wagon>();

        public Train(string name)
        {
            this.name = name;
            locomotive = new Locomotive();
            wagons = new List<Wagon>();
       }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddWagon(Wagon wagon, int weight, int yearOfManufacture)
        {
            if (wagon is FreightWagon)
            {
                wagons.Add(new FreightWagon(weight, yearOfManufacture, ((FreightWagon)wagon).CargoType, ((FreightWagon)wagon).CapacityInTons));
            }
            else
            {
                wagons.Add(wagon);
            }
        }

        public void DepartFromStation()
        {
            locomotive.Start();
        }
        public void StopAtStation()
        {
           locomotive.Stop();
        }

        public int NumberofSeats()
        {
            int totalSeats = 0;
            foreach (var wagon in wagons)
            {
                if (wagon is PassengerWagon || wagon is FirstClassPassengerWagon)
                {
                    totalSeats += (wagon is FirstClassPassengerWagon) ? ((FirstClassPassengerWagon)wagon).NumberOfSeats : ((PassengerWagon)wagon).NumberOfSeats;
                }
            }
            return totalSeats;
        }


        public Dictionary<string, (int, int, int)> SummarizeCargo()
        {
            Dictionary<string, (int, int, int)> cargoSummary = new Dictionary<string, (int, int, int)>();
            foreach (var wagon in wagons)
            {
                if (wagon is FreightWagon)
                {
                    FreightWagon freightWagon = (FreightWagon)wagon;
                    if (!cargoSummary.ContainsKey(freightWagon.CargoType))
                    {
                        cargoSummary[freightWagon.CargoType] = (0, 0, 0);
                    }
                    cargoSummary[freightWagon.CargoType] = (
                        cargoSummary[freightWagon.CargoType].Item1 + freightWagon.CapacityInTons,
                        cargoSummary[freightWagon.CargoType].Item2 + freightWagon.Weight,
                        freightWagon.YearOfManufacture
                    );
                }
            }
            return cargoSummary;
        }
    }
}
