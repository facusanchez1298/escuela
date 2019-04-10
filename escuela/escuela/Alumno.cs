using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escuela
{
    class Alumno : Persona
    {
        public override string Nombre { get; set; }
        public override string Apellido { get; set; }
        public override int dni
        {
            get
            {
                return dni;


            }

            set
            {
                if (value < 1000000)
                {
                    throw new Exception();
                }
                dni = value;

            }

        }
        public override string direccion { get; set; }
        public override int telefono { get; set; }
        public int matricula { get; }
        public Curso curso { get; set; }
        public List<Asignatura> materiasAprobadas { get; set; }
        public float promedio { get; set; }


        public Alumno(string pNombre, string pApellido, int pDni, string pDireccion, int pTelefono, int pMatricula)
        : base(pNombre, pApellido, pDni, pDireccion, pTelefono)
        {
            this.matricula = pMatricula;            
        }
    }
}
