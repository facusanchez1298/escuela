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
        public List<Asignatura> asignaturas { get;}
        

        public Profesor(string pNombre, string pApellido, int pDni, string pDireccion, int pTelefono, bool pDelCentro, Asignatura pAsignatura)
            :base(pApellido,pApellido,pDni,pDireccion,pTelefono)
        {
            this.delCentro = pDelCentro;
            this.asignaturas = new List<Asignatura>();
            asignaturas.Add(pAsignatura);
            pAsignatura.agregarProfesor(this);
           
        }

        public void serDelCentro()
        {
            this.delCentro = true;
        }

        public void dejarElCentro()
        {
            this.delCentro = false;
        }

        public void darNuevaAsignatura(Asignatura asignatura)
        {
            if (!this.asignaturas.Contains(asignatura))
            {
                this.asignaturas.Add(asignatura);
                
            }
        }

        public void dejarAsignatura(Asignatura asignatura)
        {
            if (this.asignaturas.Contains(asignatura))
            {
                this.asignaturas.Remove(asignatura);
            }
        }
    }
}
