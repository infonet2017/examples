using Business.VehicleLibrary;
using Data.VehicleRepository;
using System;

namespace Presentation.VehicleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 linea para instanciar y 1 linea para asignar cada attributo
            TerrainVehicle terrainVehicle = new TerrainVehicle();
            terrainVehicle.WheelNumber = 4;
            terrainVehicle.Weight = 500;

            //1 sola linea para instanciar y a la vez definir los atributos como JSON
            WaterVehicle waterVehicle = new WaterVehicle { HasMotor = true };

            AirVehicle airVehicle = new AirVehicle
            {
                NumberOfTurbines = 98,
                Color = "Blanco"
            };

            //Instancio el objeto que contiene las List<>
            VehicleRepository vehicleRepository = new VehicleRepository();

            //Se agrega un elemento a cada List<> especifica
            vehicleRepository.SaveWaterVehicle(waterVehicle);
            vehicleRepository.SaveAirVehicle(airVehicle);
            vehicleRepository.SaveTerrainVehicle(terrainVehicle);

            //Los 3 vehicle se guardan en una misma lista (Todos implementan IVehicle)
            vehicleRepository.SaveVehicle(waterVehicle);
            vehicleRepository.SaveVehicle(airVehicle);
            vehicleRepository.SaveVehicle(terrainVehicle);

            Console.WriteLine(airVehicle.Flap());
            Console.WriteLine(waterVehicle.ThrowAnchor());
            Console.WriteLine(terrainVehicle.GoBackward());
            Console.WriteLine("Allá le estan yendo hacia atras");
            Console.ReadKey();
        }
    }
}
