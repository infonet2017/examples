using System;
using System.Collections.Generic;
using System.Text;

namespace Business.VehicleLibrary
{
    public abstract class Vehicle: IVehicle
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public int Weight { get; set; }
        public bool IsOn { get; set; }

        //Cuerpo del constructor por defecto
        public Vehicle()
        {
            IsOn = false;
            GenerateId();
        }

        public void TurnOnOff()
        {
            if (IsOn == true)
            {
                IsOn = false;
            }
            else
            {
                IsOn = true;
            }
        }

        //Un miembro abstracto NO DEBE tener implementacion o cuerpo porque debe sera redefinido por la clase hija
        public abstract string TurnLeft();

        //Un miembro virtual DEBE tener implementacion y PUEDE ser redefinido por la clase hija
        public virtual string TurnRight() {
            return "Easy right!";
        }



        //----Miembros de la Interfaz IVehicle ----
 
        public void GenerateId()
        {
            //Guid es un tipo de identificador unico al momento de crearlo
            Id = new Guid();
        }

        public string GoFoward() {
            if (IsOn)
            {
                return "Estoy avanzando";
            }
            else
            {
                return "EL motor esta apagado no puedo avanzar";
            }
        }

        //AVOID! Siempre tratar de definir un cuerpo para un miembro de una interfaz
        public string Stop()
        {
            throw new NotImplementedException();
        }

        //--------
    }
}
