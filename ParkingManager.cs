using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ParkingManager
    {
        private string plateNumber;
        private string vehicleType;
        private string brand;
        private int flagDown;
        private DateTime parkIn;

        public ParkingManager(string plateNumber, string brand, string vehicleType)
        {
            this.plateNumber = plateNumber;
            this.brand = brand;
            this.vehicleType = vehicleType;
            parkIn = DateTime.Now;
        }
        

        public string PlateNumber
        {
            get { return plateNumber; }
            set { plateNumber = value; }
        }

        public string VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int FlagDown
        {
            get { return flagDown; }
            set { flagDown = value; }
        }

        public void printDetails()
        {
            Console.WriteLine("Plater Number: " + PlateNumber);
            Console.WriteLine("Vehicle Type: " + VehicleType);
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Park in: " + parkIn);
        }

        public DateTime ParkIn
        {
            get { return parkIn; }
            set { parkIn = value; }
        }


        public void calculateParkOut(DateTime parkOut)
        {
            
            TimeSpan diff1 = parkOut.Subtract(this.ParkIn);

            Console.Write(diff1);
        }
           

        
    }
}
