// See https://aka.ms/new-console-template for more information
using CampusVirtualLinq.Clases;

LinqMatriculas matriculas = new LinqMatriculas();

//Collection
ImprimirValores(matriculas.MatriculasCollection());

//Asignatura Calculo
ImprimirValoresAsignaturas(matriculas.MatriculasCalculo());
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

Console.WriteLine("Estado All\n");
Console.WriteLine("¿Todas las matriculas tienen estado?:" + matriculas.MatriculasEstadoAll());

Console.WriteLine("Semestre Any\n");
Console.WriteLine("'¿Existe almenos una matricula realizada para el tercer semestre?:" + matriculas.MatriculasEstadoAny());


