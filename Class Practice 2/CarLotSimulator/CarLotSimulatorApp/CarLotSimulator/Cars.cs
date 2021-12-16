using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Cars
    {
        public Cars()
        {
            CarLot.NumberOfCars++;
        }
        public Cars(int x, string a, string b, string c, string d, bool e)
        {
            Year = x;
            Make = a;
            Model = b;  
            EngineNoise = c;
            HonkNoise = d;
            IsDrivable = e;
            CarLot.NumberOfCars++;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }        
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; } = false;

        public void PleasePrint()
        {
            Console.WriteLine(Year);
            Console.WriteLine(Make);
            Console.WriteLine(Model);
            Console.WriteLine();            
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);            
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(); 
        }





    }
}
