using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class FormatoPatenteNoValidaException:ApplicationException
    {
        public FormatoPatenteNoValidaException() : base("Formato patente no válido") { }

        public FormatoPatenteNoValidaException(string message) : base(message) { }

        public FormatoPatenteNoValidaException(string message, Exception innerException) : base(message, innerException) { }
    }
}
