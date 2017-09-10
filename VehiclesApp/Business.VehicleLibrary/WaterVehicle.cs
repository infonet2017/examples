using System;
using System.Collections.Generic;
using System.Text;

namespace Business.VehicleLibrary
{
    public class WaterVehicle: Vehicle
    {
        public bool HasMotor { get; set; }
    
        public string ThrowAnchor() {
            return "Estamos anclando. Allá le estan anclando";
        }

        //Override al metodo abstract heredado
        public override string TurnLeft()
        {
            return "No puedo girar a la izquierda al igual que Zoolander";
        }

        //Override al metodo virtual heredado
        public override string TurnRight()
        {
            if (HasMotor) {
                return "Girando a la izquierda con motor";
            } else {
                return "Girando a manopla";
            }
            
        }
    }
}
