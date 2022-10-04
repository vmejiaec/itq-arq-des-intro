using Consola;
using Entidades;


// Persistencia
// Inyección de dependencias
using (ITQContext db = new ITQContext(ITQDB.getItqDb()))
{
    db.Init();
    Periodo periodoActual = Datos.Escenario01();
    db.Periodos.Add(periodoActual);
    db.SaveChanges();

    // Cuál es el estudiante con Id 3
    Console.WriteLine("Datos del estudiante con id=3");
    var estudianteId3 = db.Estudiantes
        .Single(estudiante => estudiante.Id == 3);
    Console.WriteLine("  "+estudianteId3.Id + " " + estudianteId3.Nombre);

    // Cuáles son los cursos de Maria
    var estudianteMaria = db.Estudiantes
        .Single(estudiante => estudiante.Nombre == "Maria");
    Console.WriteLine("Cursos de María");
    foreach (var curso in estudianteMaria.Cursos)
    {
        Console.WriteLine("  "+ curso.Id+" "+curso.Nombre);
    }

    // De cada período listar sus cursos y de cada curso sus estudiantes
    var periodos = db.Periodos;
    Console.WriteLine("Lista de períodos, cursos y estudiantes");
    foreach (var periodo in periodos)
    {
        Console.WriteLine("\tPeríodo: "+ periodo.Descripcion);
        foreach(var curso in periodo.Cursos)
        {
            Console.WriteLine("\t\tCurso: " + curso.Nombre);
            foreach(var estudiante in curso.Estudiantes)
            {
                Console.WriteLine("\t\t\t- "+estudiante.Id + " " + estudiante.Nombre);
            }
        }
    }
}

Console.WriteLine("FIN.");