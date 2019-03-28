using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escuela
{
    class Institucion
    {
        private int matricula = 0;
        private List<Curso> cursos;

        static void Main(string[] args)
        {
            
        }

        public Curso crearCurso(int año, char division, Aula aula)
        {
            Curso curso = new Curso(año, division, aula);
            return null;
        }

        public Alumno crearAlumno(string nombre, string apellido, int dni, string direccion, int telefono, Curso curso)
        {
            Alumno alu = new Alumno(nombre, apellido, dni, direccion, telefono, this.matricula);
            this.matricula = this.matricula + 1;
            return alu;
        }

        public Profesor crearProfesor(string nombre, string apellido, int dni, string direccion, int telefono, bool delCentro, Asignatura asignatura)
        {
            Profesor profesor = new Profesor(nombre, apellido, dni, direccion, telefono, delCentro, asignatura);
            return profesor;
        }

        public Asignatura crearAsignatura(string nombre)
        {
            Asignatura asignatura = new Asignatura(nombre);
            return asignatura;
        }
    }
}



