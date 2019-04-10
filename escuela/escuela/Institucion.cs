using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escuela
{
    class Institucion
    {
        int proyectores = 10;
        private int matricula = 0;
        private List<Curso> cursos = new List<Curso>();

        static void Main(string[] args)
        {
            Form1 form1 = new Form1();
            Console.WriteLine("bienvenido a el sistema escolar, que desea hacer?");
            Console.ReadKey();
        }
        
        public void crearNuevoCurso(int año, char division, Aula aula)
        {
            Curso curso = new Curso(año, division, aula);
            for(int i = 0; i < cursos.Count; i++)
            {
                if((cursos.ElementAt(i).getAño() == año)&&(cursos.ElementAt(i).getDivision() == division)) 
                {
                    throw new Exception("no podes tener años y divisiones iguales");
                }

                if (cursos.ElementAt(i).getAula().Equals(aula))
                {
                    throw new Exception("no podes tenes dos cursos en el mismo aula");
                }
            }

            cursos.Add(curso);
        }

        public void crearAlumno(string nombre, string apellido, int dni, string direccion, int telefono, Curso curso)
        {
            if (curso.lleno())
            {
                Alumno alu = new Alumno(nombre, apellido, dni, direccion, telefono, this.matricula);
                this.matricula = this.matricula + 1;
                curso.agregarAlumno(alu);
            }
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

        public Curso buscarCursoAlumno(Alumno alumno)
        {
            for(int i = 0; i< cursos.Count; i++)
            {
                if (cursos.ElementAt(i).ExisteAlumno(alumno)) return cursos.ElementAt(i);
            }

            throw new Exception("el alumno no esta en ningun curso");
        }

        public void ponerProyector(Aula aula)
        {

            if (this.proyectores > 0)
            {
                aula.colocarProyector();
                this.proyectores = this.proyectores - 1;
            }
            else throw new Exception("no tiene suficientes proyectores, quitelos de otro aula para colocarlo aqui");
        }
       
        public void quitarProyector(Aula aula)
        {
            if (aula.quitarProyector())
            {
                this.proyectores++;
            }
        }
    }
}



