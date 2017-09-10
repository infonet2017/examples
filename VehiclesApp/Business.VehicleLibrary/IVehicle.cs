using System;
using System.Collections.Generic;
using System.Text;

namespace Business.VehicleLibrary
{
    /// Interface utilizada para generar la firma de 3 miembros que deben implementar las clases que implementen la interfaz
    public interface IVehicle
    {
        void GenerateId();
        string GoFoward();
        string Stop();
    }
}
