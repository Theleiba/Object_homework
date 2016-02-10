using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3_kt4
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        public void PrintData()
        {
            Console.WriteLine("Name: " + Name + " Speed: " + Speed + " Tyres: " + Tyres);
        }

        public override string ToString()
        {
            return String.Format("Name: {0} Speed: {1} Tyres: {2}", Name, Speed, Tyres);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle car = new Vehicle();
            car.Name = "Saab 95";
            car.Speed = 240;
            car.Tyres = 4;
            car.PrintData();
            Console.WriteLine(car.ToString());

            Vehicle ufo = new Vehicle();
            ufo.Name = "UFO";
            ufo.Speed = 78993864;
            ufo.Tyres = 3;
            ufo.PrintData();
            Console.WriteLine(ufo.ToString());
        }
    }
}
