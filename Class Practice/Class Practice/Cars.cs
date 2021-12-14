using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice
{
    internal class Cars
    {
        public Cars(string make, string model, int year)
        {
            Make = make;
            Model = model;  
            Year = year;
        }
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }     
        
        public void PrintPlease()
        {
            Console.WriteLine(Make);
            Console.WriteLine(Model);
            Console.WriteLine(Year);
        }
    }
}
