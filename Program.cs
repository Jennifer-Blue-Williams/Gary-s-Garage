using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                BatteryKWh = 10,
                MainColor = "Black",
                MaximumOccupancy = 2
            };

            Tesla modelS = new Tesla()
            {
                BatteryKWh = 15,
                MainColor = "Burgundy",
                MaximumOccupancy = 5
            };

            Cessna mx410 = new Cessna()
            {
                FuelCapacity = 80,
                MainColor = "White",
                MaximumOccupancy = 4
            };

            Ram Rebel = new Ram()
            {
                FuelCapacity = 25,
                MainColor = "Silver",
                MaximumOccupancy = 4
            };

            fxs.Drive();
            fxs.Stop();
            fxs.Turn("Right");

            modelS.Drive();
            modelS.Stop();
            modelS.Turn("Right");

            mx410.Drive();
            mx410.Stop();
            mx410.Turn("Right");

            Rebel.Drive();
            Rebel.Stop();
            Rebel.Turn("Left");
        }
    }
}
