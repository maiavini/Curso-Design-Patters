using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Vehicles
{
    class Car : Vehicle
    {
        protected int Seates;
        protected int Doors;

        public Car(int seates, int doors, string color, int year, double engine) :base( color, year, engine)
        {
            this.Seates = seates;
            this.Doors = doors;
        }


        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro {Color}, {Year}, {Engine}, {Seates} lugares , {Doors} portas");
        }
    }
}
