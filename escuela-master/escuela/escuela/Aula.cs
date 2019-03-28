using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escuela
{
    class Aula
    {
        public int capacidad { get; set; }
        public int numero { get; set; }
        public bool tieneInternet { get; set; }
        public bool tieneProyector { get; set; }


        Aula(int capacidad, int numero, bool tieneProyector, bool tieneInternet)
        {
            this.capacidad = capacidad;
            this.numero = numero;
            this.tieneInternet = tieneInternet;
            this.tieneProyector = tieneProyector;
        }
    }
}
