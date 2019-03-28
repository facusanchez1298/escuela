using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escuela
{
    class Profesor : Persona
    {
        public override string Nombre { get; set; }
        public override string Apellido  { get; set; }
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
        public bool delCentro { get; set;}
        public List<Asignatura> asignaturas { get; set;}
        public List<Curso> cursos { get; set; }

        public Profesor(string pNombre, string pApellido, int pDni, string pDireccion, int pTelefono, bool pDelCentro, Asignatura pAsignatura)
            :base(pApellido,pApellido,pDni,pDireccion,pTelefono)
        {
            this.delCentro = pDelCentro;
            this.asignaturas = new List<Asignatura>();
            asignaturas.Add(pAsignatura);
            this.cursos = new List<Curso>();
            
        }


    }
}
