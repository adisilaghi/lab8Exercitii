using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8Exercitii
{
    public class PassengerWagon : Wagon
    {
        public int NumberOfSeats { get; set; }

        public PassengerWagon(int weight, int yearOfManufacture, int numberOfSeats)
            : base(weight, yearOfManufacture)
        {
            NumberOfSeats = numberOfSeats;
        }
         }

    public class FirstClassPassengerWagon : PassengerWagon
    {
        public FirstClassPassengerWagon(int weight, int yearOfManufacture, int numberOfSeats) 
            :base(weight, yearOfManufacture, numberOfSeats)
        {
            Console.WriteLine($"First Class Passenger Wagon with {numberOfSeats} seats.");
        }

        public void StartAirConditioning()
        {
            Console.WriteLine("Air conditioning started in first class passenger wagon.");
        }

        public void StopAirConditioning()
        {
            Console.WriteLine("Air conditioning stopped in first class passenger wagon.");
        }
    }
}
