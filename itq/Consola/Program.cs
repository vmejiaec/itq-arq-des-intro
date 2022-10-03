using Consola;
using Entidades;
using Microsoft.EntityFrameworkCore;

Periodo periodoActual = Datos.Escenario01();

// Persistencia
// Inyección de dependencias
using (ITQContext db = new ITQContext(ITQDB.getItqDb()))
{    
    db.Periodos.Add(periodoActual);
    db.SaveChanges();
    
    // Cuál es el estudiante con Id 3
    var res = db.Estudiantes
        .Single(estudiante => estudiante.EstudianteId == 3);

    Console.WriteLine(res.EstudianteId + " " + res.Nombre);

    // En qué cursos está matriculada María
    var cursosMaria = db.Cursos
        .Include(curso => curso.ListaEstudiantes)
        .Where(curso => curso.ListaEstudiantes.Exists(estudiante => estudiante.Nombre == "Maria"));

    foreach (var curso in cursosMaria)
    {
        Console.WriteLine(curso.Id+" "+curso.Nombre);
    }
}

Console.WriteLine("FIN.");