using Business.VehicleLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.VehicleRepository
{
    public class VehicleRepository
    {
        //Las siguientes 3 List estan restringidas a una CLASE del tipo declarada
        public List<WaterVehicle> WaterList { get; set; }
        public List<AirVehicle> AirList { get; set; }
        public List<TerrainVehicle> TerrainList { get; set; }

        //Esta lista está restringida a cualquier clase que IMPLEMENTE la interfaz IVehicle
        public List<IVehicle> VehicleList { get; set; }

        public VehicleRepository()
        {
            //Siempre Inicializar List<> antes de operar
            WaterList = new List<WaterVehicle>();
            AirList = new List<AirVehicle>();
            TerrainList = new List<TerrainVehicle>();
            VehicleList = new List<IVehicle>();
        }

        //Solo recibe objetos de la clase WaterVehicle
        public void SaveWaterVehicle(WaterVehicle waterVehicle) {
            WaterList.Add(waterVehicle);
        }

        //Solo recibe objetos de la clase AirVehicle
        public void SaveAirVehicle(AirVehicle airVehicle)
        {
            AirList.Add(airVehicle);
        }

        //Solo recibe objetos de la clase TerrainVehicle
        public void SaveTerrainVehicle(TerrainVehicle terrainVehicle)
        {
            TerrainList.Add(terrainVehicle);
        }

        //Recibe cualquier objeto que implemente IVehicle
        public void SaveVehicle(IVehicle vehicle)
        {
            VehicleList.Add(vehicle);
        }
    }
}
