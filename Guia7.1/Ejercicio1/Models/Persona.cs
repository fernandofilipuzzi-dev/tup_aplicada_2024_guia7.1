
using System;
using System.Collections;
using System.Net.Mime;

namespace Ejercicio1.Models
{
    public class Persona
    {
        int dni;
        public int DNI 
        {
            get 
            {
                return dni;
            }
            set
            {
                if (value <= 1000000)
                    throw new RangoDniIncorrectoException();
                dni = value;
            }
        }
        public string Nombre { get; set; }

        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }
    }
}
