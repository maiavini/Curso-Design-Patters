using System;
using System.Collections.Generic;
using System.Text;

namespace OCP.Vehicles
{
    class Motocycle : Vehicle
    {
        

        public Motocycle(string color, int year, double engine):base(color, year, engine)
        {
            ConfigureMotocycle();
        }

        public void ConfigureMotocycle()
        {
            Console.WriteLine($"Criando uma moto {Color}, {Year}, {Engine} cilindradas");
        }
    }
}
