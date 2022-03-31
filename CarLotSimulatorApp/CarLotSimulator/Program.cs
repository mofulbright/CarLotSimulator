using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot carLot = new CarLot();

            //Dot notation
            var vw = new Car();
            vw.Year = 2001;
            vw.Make = "Volkswagen";
            vw.Model = "Passat";
            vw.EngineNoise = "Rattling";
            vw.HonkNoise = "beep beep";
            vw.IsDriveable = true;

            carLot.ParkingLot.Add(vw);
            

            //Object Initializer syntax
            var acura = new Car()
            {
                Make = "Acura",
                Model = "TL",
                Year = 2001,
                IsDriveable = true,
                EngineNoise = "purr",
                HonkNoise = "honk honk"
            };
            carLot.ParkingLot.Add(acura);
            

            //Custom Constructor
            var lincoln = new Car(2010, "Lincoln", "MKZ", "Grrrrr", "ROAR", true);
            carLot.ParkingLot.Add(lincoln);

            //Instantiate CarLot



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach(var car in carLot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                Console.WriteLine("------------------");

            }
        }
    }
}
