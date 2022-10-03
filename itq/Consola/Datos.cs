using Entidades;

namespace Consola
{
    public class Datos
    {
        public static Periodo Escenario01()
        {
            /*  En el período actual asignar :
                al curso de Prog, los estudiantes juan y maría,
                al curso de Web, los estudiantes jose y pedro
                al curso de DB, los estudiante pedro y maría
            */

            // Creación de datos
            // Periodos
            Periodo periodoActual = new Periodo() { Descripcion = "2022 PAO2" };
            // Cursos
            Curso cursoProg = new Curso() { Nombre = "Programación I" };
            Curso cursoWeb = new Curso() { Nombre = "Diseño Web" };
            Curso cursoDB = new Curso() { Nombre = "Bases de Datos" };
            // Estudiantes
            Estudiante estudianteJuan = new Estudiante() { Nombre = "Juan" };
            Estudiante estudiantePedro = new Estudiante() { Nombre = "Pedro" };
            Estudiante estudianteMaria = new Estudiante() { Nombre = "Maria" };
            Estudiante estudianteJose = new Estudiante() { Nombre = "Jose" };

            // Registro de estudiantes en sus cursos del período actual
            cursoProg.Estudiantes = new List<Estudiante>() { estudianteJuan, estudianteMaria };
            cursoWeb.Estudiantes = new List<Estudiante>() { estudianteJose, estudianteMaria };
            cursoDB.Estudiantes = new List<Estudiante>() { estudiantePedro, estudianteJuan };

            periodoActual.Cursos = new List<Curso>() { cursoProg, cursoDB, cursoWeb };

            return periodoActual;
        }
    }
}
