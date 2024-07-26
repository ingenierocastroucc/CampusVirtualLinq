// See https://aka.ms/new-console-template for more information
using CampusVirtualLinq.Clases;

LinqMatriculas matriculas = new LinqMatriculas();

//Collection
ImprimirValores(matriculas.MatriculasCollection());

//Asignatura Calculo
ImprimirValoresAsignaturas(matriculas.MatriculasCalculo());

ImprimirAsignaturasCsharp(matriculas.MatriculasContains());

ImprimirAsignaturasCsharpOrder(matriculas.MatriculasOrderBy());

ImprimirAsignaturasMatriculasTake(matriculas.MatriculasTake());

ImprimirAsignaturasMatriculasTakeWhile(matriculas.MatriculasTakeWhile());

ImprimirAsignaturasSkip(matriculas.MatriculasSkip());

void ImprimirValores(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Collection\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

void ImprimirValoresAsignaturas(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Asignaturas\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

void ImprimirAsignaturasCsharp(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Matriculas con asignaturas C#\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

void ImprimirAsignaturasCsharpOrder(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Matriculas con asignaturas C# ordenadas\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

void ImprimirAsignaturasMatriculasTake(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Matriculas con asignaturas C#, primeros dos estudiantes\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

void ImprimirAsignaturasMatriculasTakeWhile(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Matriculas con asignaturas C#, estudiantes matriculados en la fecha '2024-07-23'\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

void ImprimirAsignaturasSkip(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Matriculas con asignaturas C#, aplicando Take/Skip\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

Console.WriteLine("Estado All\n");
Console.WriteLine("¿Todas las matriculas tienen estado?:" + matriculas.MatriculasEstadoAll());

Console.WriteLine("Semestre Any\n");
Console.WriteLine("¿Existe almenos una matricula realizada para el tercer semestre?:" + matriculas.MatriculasEstadoAny());

Console.WriteLine("Matriculas Select\n");
var matriculasList = matriculas.MatriculasSelect();



