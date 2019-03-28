using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escuela
{
    abstract class Persona
    {
        public abstract string Nombre { get; set; }
        public abstract string Apellido { get; set; }
        public abstract int dni { get; set; }
        public abstract string direccion { get; set; }
        public abstract int telefono { get; set; }


        public Persona(string pNombre, string pApellido, int pDni, string pDireccion, int pTelefono)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.dni = pDni;
            this.direccion = pDireccion;
            this.telefono = pTelefono;
        }
    }
}
