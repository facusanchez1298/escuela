using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escuela
{
    class Asignatura
    {
        public string  nombre {get; set;}
        public List<int> examenes {get; set;}
        public List<int> recuperatorios {get; set;}
        public List<Asignatura> correlativas {get; set;}
        public List<Profesor> profesors {get; set;}

        public Asignatura(string nombre)
        {
            this.nombre = nombre;
        }




    }
}
