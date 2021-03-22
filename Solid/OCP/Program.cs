using System;

namespace OCP
{
    class Program
    {
        // PRINCIPIO OPEN/CLOSE: AS CLASSES DEVEM ESTAR ABERTAS PARA EXTENSÕES, AICIONAR MAIS RECURSOS, PORÉM ELA DEVE ESTAR 
        // FECHADA PARA O QUE JÁ ESTÁ FEITO E JÁ IMPLEMENTADO
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.Carro;

            if (type == TypeVehicle.Carro)
            {
                Vehicles vehicles = new Vehicles()
            }
        }
    }
}
