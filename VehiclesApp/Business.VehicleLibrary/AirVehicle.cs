using System;
using System.Collections.Generic;
using System.Text;

namespace Business.VehicleLibrary
{
    public class AirVehicle: Vehicle
    {
        public int NumberOfTurbines { get; set; }

        public string Flap()
        {
            return "Estamos desplegando las ruedas. Allá le despliegan";
        }

        //AVOID same case as TerrainVehicle
        public override string TurnLeft()
        {
            throw new NotImplementedException();
        }
    }
}
