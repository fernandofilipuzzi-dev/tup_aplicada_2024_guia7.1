using System;
using System.Text.RegularExpressions;

namespace Ejercicio1.Models
{
    public class RegistroVehiculo:IComparable
    {
        public string Patente { get; set; }
        public string Serie { get; set; }

        public Persona Propietario { get; set; }

        public RegistroVehiculo(string patente, Persona propietario, int serie)
        {
            this.Patente = patente;
            this.Propietario = propietario;
            this.Serie = serie.ToString();

            Match m = Regex.Match(patente.Trim(), @"^[A-Z]{3}\s*[0-9]{3}$",RegexOptions.IgnoreCase);
            if (m.Success == false)
                throw new FormatException();
        }

        public int CompareTo(object obj)
        {
            RegistroVehiculo otro=obj as RegistroVehiculo;
            if(otro!=null)
                return this.Patente.CompareTo(otro.Patente);
            return 1;
        }

        public override string ToString()
        {
            return $"{Patente} - Propietario: {Propietario.Nombre}({Propietario.DNI})";
        }
    }
}
