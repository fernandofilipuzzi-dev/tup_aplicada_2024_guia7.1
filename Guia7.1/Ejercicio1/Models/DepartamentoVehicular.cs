using System;

namespace Ejercicio1.Models
{
using System.Collections;
    using System.Collections.Generic;

    public class DepartamentoVehicular
    {
        public int CantidadRegistros
        {
            get { return registros.Count; }
        }

        int serie;

        public List<RegistroVehiculo> registros=new List<RegistroVehiculo>();

        public RegistroVehiculo RegistrarVehiculo(Persona propietario, string patente)
        {
            RegistroVehiculo nuevo = new RegistroVehiculo(patente, propietario, ++serie);
            registros.Add(nuevo);
            return nuevo;
        }

        public void OrdenarRegistros()
        {
            registros.Sort();
        }

        public RegistroVehiculo VerRegistro(int idx)
        {
            if (idx >= 0 && idx < CantidadRegistros)
            { 
                return registros[idx];
            }
            return null;
        }
    }
}

