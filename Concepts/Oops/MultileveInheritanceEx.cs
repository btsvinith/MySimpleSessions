using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSessions.Concepts.Oops
{
    internal class MultileveInheritanceEx
    {
        public void Exec()
        {
            Car myObj = new Car();
            //myBike.Weight = 2.33f;
            //myBike.Height = 20.5f;
            //myBike.Color = "Red";
            //myBike.TravelType = "Bus";
            //myBike.ManufacturingDate = new DateTime(2001, 10, 26);

            //myBike.NoOfMirrors = 2;
            //myBike.ChainLength = 5.5f;

            //myBike.FuelType = "Petrol";
            //myBike.HandBarType = "Curve";
            myObj.Print();

            Console.ReadLine();


        }
        class Vehicle
        {
            public float Weight { get; set; }
            public float Height { get; set; }
            public string? Color { get; set; }

            public string? TravelType { get; set; }
            public float Cost { get; set; }

            public DateTime? ManufacturingDate { get; set; }
            public void Print()
            {
                Console.WriteLine("Vehicle Properties...");
                Console.WriteLine("Weight - " + Weight);
                Console.WriteLine("Height - " + Height);
                Console.WriteLine("Color - " + Color);
                Console.WriteLine("TravelType - " + TravelType);
                Console.WriteLine("ManufacturingDate - " + ManufacturingDate);

            }
        }

        class Roadway : Vehicle
        {
            public int NoOfWheels { get; set; }

            public int NoOfSeats { get; set; }

            public int NoOfMirrors { get; set; }

            public string? BreakType { get; set; }
            public void Print()
            {
                base.Print();
                Console.WriteLine("Roadway Properties...");
                Console.WriteLine("NoOfWheels - " + NoOfWheels);
                Console.WriteLine("NoOfSeats - " + NoOfSeats);
                Console.WriteLine("NoOfMirrors - " + NoOfMirrors);
                Console.WriteLine("BreakType - " + BreakType);


            }

        }

        class TwoWheeler : Roadway
        {
            public int StandType { get; set; }

            public int NoOfFootRests { get; set; }

            public bool HasHeadLight { get; set; }

            public bool HasExternalLock { get; set; }

            public string? HandBarType { get; set; }
            public float ChainLength { get; set; }

            public void Print()
            {
                base.Print();
                Console.WriteLine("Two Wheeler Properties...");
                Console.WriteLine("StandType - " + StandType);

                Console.WriteLine("NoOfFootRests - " + NoOfFootRests);
                Console.WriteLine("HasHeadLight - " + HasHeadLight);

                Console.WriteLine("HasExternalLock - " + HasExternalLock);
                Console.WriteLine("HandBarType - " + HandBarType);
                Console.WriteLine("ChainLength - " + ChainLength);
            }

        }

        class Bike : TwoWheeler
        {
            public string? FuelType { get; set; }


            public bool HasToolBox { get; set; }

            public string? SpeedameterType { get; set; }

            public void Print()
            {
                base.Print();
                Console.WriteLine("Bike Properties...");
                Console.WriteLine("FuelType - " + FuelType);


                Console.WriteLine("HasToolBox - " + HasToolBox);

                Console.WriteLine("SpeedameterType - " + SpeedameterType);


            }

        }
        class Cycle : TwoWheeler
        {
            public int Pedal { get; set; }
            public float Spokes { get; set; }

            public void Print()
            {
                base.Print();
                Console.WriteLine("Cycle Properties...");
                Console.WriteLine("Pedal - " + Pedal);
                Console.WriteLine("Spokes - " + Spokes);
            }

        }

        class FourWheeler : Roadway
        {
            public string? SterringType { get; set; }

            public int NoOfSparewheels { get; set; }

            public int NoOfWiper { get; set; }

            public int NoOfGear { get; set; }

            public string? WindowType { get; set; }


            public void Print()
            {
                base.Print();
                Console.WriteLine("FourWheeler Properties...");
                Console.WriteLine("Sterring - " + SterringType);
                Console.WriteLine("Sparewheel - " + NoOfSparewheels);
                Console.WriteLine("Wiper - " + NoOfWiper);
                Console.WriteLine("Gear - " + NoOfGear);
                Console.WriteLine("Window - " + WindowType);

            }
        }
        class Car : FourWheeler
        {
            public string? FuelType { get; set; }

            public int Clutch { get; set; }

            public void Print()
            {
                base.Print();
                Console.WriteLine("Car Properties...");
                Console.WriteLine("FuelType - " + FuelType);
                Console.WriteLine("Clutch - " + Clutch);

            }
        }
    }
}
