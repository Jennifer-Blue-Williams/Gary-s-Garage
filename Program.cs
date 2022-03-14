using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.CurrentChargePercentage = 45;
            fxs.MainColor = "Midnight Blue";
            fxs.BatteryKWh = 7.2;
            fxs.Name = "Hyper Zero";

            Zero fx = new Zero();
            fx.CurrentChargePercentage = 88;
            fx.MainColor = "Puke Green";
            fx.BatteryKWh = 3.2;
            fx.Name = "Eddie Bauer Edition Zero";

            Tesla modelS = new Tesla();
            modelS.CurrentChargePercentage = 21;
            modelS.MainColor = "Periwinkle";
            modelS.BatteryKWh = 9.9;
            modelS.Name = "Purple Monster";

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
                };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            ram.CurrentTankPercentage = 32;
            ram.MainColor = "Pewter";
            ram.FuelCapacity = 23.2;
            ram.Name = "The Longhorn";

            Cessna cessna150 = new Cessna();
            cessna150.CurrentTankPercentage = 91;
            cessna150.MainColor = "White";
            cessna150.FuelCapacity = 54.2;
            cessna150.Name = "The Longhorn";

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}
