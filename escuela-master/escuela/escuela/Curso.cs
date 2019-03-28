using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escuela
{
    class Curso
    {
        private int año { get; set; }
        private char division { get; set; }
        private Aula aula { get; set; }
        private List<Asignatura> asignaturas { get; set; }
        private List<Alumno> alumnos { get; set; }
        

        public Curso(int año, char division, Aula aula)
        {
            this.año = año;
            this.division = division;
            this.aula = aula;
            this.asignaturas = new List<Asignatura>();
            this.alumnos = new List<Alumno>();
        }

        public void agregarAsignatura( Asignatura asignatura)
        {
            if (!this.asignaturas.Contains(asignatura))
            {
                this.agregarAsignatura(asignatura);
            }
        }
        
        public void agregarAsignaturas(List<Asignatura> asignaturas)
        {
            for(int i = 0; i < asignaturas.Count; i++)
            {
                if (!this.asignaturas.Contains(asignaturas.ElementAt(i)))
                {
                    this.agregarAsignatura(asignaturas.ElementAt(i));
                }

            }
        }

        public void cambiarAsignaturas(List<Asignatura> asignaturas)
        {
            if (asignaturas.ElementAt(0) != null)
            {
                this.asignaturas = asignaturas;
            }
        }

        public void borrarAsignatura(Asignatura asignatura)
        {
            if (this.asignaturas.Contains(asignatura))
            {//si el elemento existe en la lista, entonces
                int index = this.asignaturas.IndexOf(asignatura);//busca el index del elemento
                asignaturas.RemoveAt(index);
            }
        }

        public void agregarAlumno(Alumno alumno)
        {
            if (aula.capacidad >= alumnos.Count)
            {
                if (!this.alumnos.Contains(alumno))
                {
                    this.alumnos.Add(alumno);
                    alumno.curso = this;
                }
            }
        }

        public void agregarAlumnos(List<Alumno> alumnos)
        {
            for(int i = 0; i < alumnos.Count; i++)
            {
                if ((!this.alumnos.Contains(alumnos.ElementAt(i))) && (alumnos.ElementAt(i) != null))
                {
                    agregarAlumno(alumnos.ElementAt(i));
                    alumnos.ElementAt(i).curso = this;
                }
            }
        }

        public void borrarAlumno(Alumno alumno)
        {
            int index = this.alumnos.IndexOf(alumno);

            if(index != -1)
            {
                this.alumnos.Remove(alumno);
            }


        }

        public void vaciarAlumnos()
        {
            this.alumnos = new List<Alumno>();
        }
        
        public void cambiarAula(Aula aula)
        {
            this.aula = aula;
        }


    }
}
