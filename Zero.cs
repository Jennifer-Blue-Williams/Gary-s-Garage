using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public double CurrentChargePercentage { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeeooooowwwww!");
        }
        public void ChargeBattery()
        {
            BatteryKWh = 50;
            CurrentChargePercentage = 100;
        }

    }
}