using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Vehicles
{
    class Vehicle
    {
        protected string Color;
        protected int Year;
        protected double Engine;

        public Vehicle(string color, int year, double engine)
        {
            this.Color = color;
            this.Year = year;
            this.Engine = engine;
        }

        public void  StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }

        

    }

   

   
}
