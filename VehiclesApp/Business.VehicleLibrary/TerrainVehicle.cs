using System;
using System.Collections.Generic;
using System.Text;

namespace Business.VehicleLibrary
{
    public class TerrainVehicle: Vehicle
    {
        public int WheelNumber { get; set; }
        
        //Overload al metodo heredado GoFoward de Vehicle. CREO QUE NO VIMOS SOBRECARGA
        //GoFoward() sin parametros pertenece a Vehicle mientras que GoFoward(int) pertenece a TerrainVehicle
        //La diferencia entre usar uno u otro esta en el numero y tipos de parametros. NO ES UN OVERRIDE!
        public string GoFoward(int meters) {
            int accelerate = WheelNumber * Speed;
            return "Estoy yendo hacia adelante a " + accelerate + " kmh durante "+ meters;
        }

        public string GoBackward() {
            int accelerate = (WheelNumber * Speed) / 2;
            return "Estoy yendo hacia atras a " + accelerate + " kmh";
        }

        //AVOID! No es responsabilidad de la capa Business conocer sobre la tecnologia usada en Presentation (Console)
        public void GoBackwardConsole()
        {
            int accelerate = (WheelNumber * Speed) / 2;
            Console.WriteLine("Estoy yendo hacia atras a " + accelerate + " kmh");
        }

        //AVOID! Siempre tratar de implementar un miembro que es abstracto
        public override string TurnLeft()
        {
            throw new NotImplementedException();
        }

        //AVOID! No hacer un override llamando solamente a base
        public override string TurnRight()
        {
            return base.TurnRight();
        }
    }
}
