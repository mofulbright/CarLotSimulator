using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarLot
    {
        public CarLot()
        {

        }
        public List<Car> ParkingLot { get; set; } = new List<Car>();

        private static int _numberOfCars = 0;
        
        public static void UpdateCars()
        {
            _numberOfCars++;
        }
        public static int ShowInventory()
        {
            return _numberOfCars;
        }
    }
}
