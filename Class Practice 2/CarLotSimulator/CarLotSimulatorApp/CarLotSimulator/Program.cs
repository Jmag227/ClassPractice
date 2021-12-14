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
            CarLot lot = new CarLot();
            
            
            var car1 = new Cars(2020, "Ford", "Mustang", "Vroom", "Beep Beep", true);
            car1.PleasePrint();
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            lot.CarList.Add(car1);



            var car2 = new Cars();
            car2.Year = 2013;
            car2.Make = "Scion";
            car2.Model = "TC";
            car2.EngineNoise = "Whirrrrr, Vroom";
            car2.HonkNoise = "Beeeeeeeeep";
            car2.IsDrivable = true;

            car2.PleasePrint();
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();
            lot.CarList.Add(car2);


            var car3 = new Cars() { Make = "Trek", Model = "2000 Series", Year = 2015, EngineNoise = "Laborious breathing", HonkNoise = "Man yells at car...'&*#$%#@!'", IsDrivable = true};
            car3.PleasePrint();
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();
            lot.CarList.Add(car3);


            Console.WriteLine("Car Lot Inventory");

            foreach (var car in lot.CarList)
            {
                Console.WriteLine();
                Console.WriteLine($"Make: {car.Year} Model: {car.Model} Year {car.Year}");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
