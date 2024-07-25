// See https://aka.ms/new-console-template for more information
using CampusVirtualLinq.Clases;

LinqMatriculas matriculas = new LinqMatriculas();

ImprimirValores(matriculas.MatriculasCollection());

void ImprimirValores(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}


