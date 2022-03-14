using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            {
                FuelCapacity = 40;
                CurrentTankPercentage = 100;
            }
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you. Rrrrrruuummmbbbble!");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Ram comes to a screeching halt!");
        }
    }
}