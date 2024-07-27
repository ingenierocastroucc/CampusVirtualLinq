#region Documentación
/************************************************************************************************************
 * Propiedad intelectual de Pedro Castro
 ************************************************************************************************************                                                                 
 * Descripcion   : Clase usada como logica de negocio para la impresion en consola de las funciones de la clase LinqMatriculas
 * 
 * Autor         : Pedro Castro                                                                                         
 * Fecha         : <25/07/2016>                                                                             
 *                                                                                                           
 * Fecha         Autor (Alias)      Modificación                                                               
 * ===========   ============       ========================================================================= 
 * 25/07/2016     Pedro Castro       1. Creación de Program.cs
 * 26/07/2016     Pedro Castro       2. Se agregan llamados a las funciones
 ***********************************************************************************************************/
#endregion Documentación

using CampusVirtualLinq.Clases;

LinqMatriculas matriculas = new LinqMatriculas();

//Collection
ImprimirValores(matriculas.MatriculasCollection());

//Asignatura Calculo funcion where
ImprimirValoresAsignaturas(matriculas.MatriculasCalculo());
//Funcion Contains
ImprimirAsignaturasCsharp(matriculas.MatriculasContains());
//Funcion OrderBy
ImprimirAsignaturasCsharpOrder(matriculas.MatriculasOrderBy());
//Funcion Take
ImprimirAsignaturasMatriculasTake(matriculas.MatriculasTake());
//Funcion TakeWhile
ImprimirAsignaturasMatriculasTakeWhile(matriculas.MatriculasTakeWhile());
//Funcion Skip
ImprimirAsignaturasSkip(matriculas.MatriculasSkip());

//Imprime en consola todos los valores de la coleccion
void ImprimirValores(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Collection\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura
void ImprimirValoresAsignaturas(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Asignaturas\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura
void ImprimirAsignaturasCsharp(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Matriculas con asignaturas C#\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura y con un orden especifico
void ImprimirAsignaturasCsharpOrder(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Matriculas con asignaturas C# ordenadas\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura, tomando valores especificos
void ImprimirAsignaturasMatriculasTake(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Matriculas con asignaturas C#, primeros dos estudiantes\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura, tomando valores especificos
void ImprimirAsignaturasMatriculasTakeWhile(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Matriculas con asignaturas C#, estudiantes matriculados en la fecha '2024-07-23'\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura, evitando tomar valores especificos
void ImprimirAsignaturasSkip(IEnumerable<Matriculas> listaMatriculas)
{
    Console.WriteLine("Matriculas con asignaturas C#, aplicando Take/Skip\n");
    Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}\n", "NombreAsignatura", "Profesor", "FechaRegistro", "Estudiante");
    foreach (var item in listaMatriculas)
    {
        Console.WriteLine("{0, -15}, {1, 15}, {2,15}, {3,15}", item.NombreAsignatura, item.Profesor, item.FechaRegistro.ToShortDateString(), item.Estudiante);
    }
}

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura, por la funcion select
Console.WriteLine("Matriculas Select\n");
var matriculasList = matriculas.MatriculasSelect();

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura, por la funcion All
Console.WriteLine("Estado All\n");
Console.WriteLine("¿Todas las matriculas tienen estado?:" + matriculas.MatriculasEstadoAll());

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura, por la funcion Any
Console.WriteLine("Semestre Any\n");
Console.WriteLine("¿Existe almenos una matricula realizada para el tercer semestre?:" + matriculas.MatriculasEstadoAny());

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura, por la funcion Count
Console.WriteLine("Cantidad de Materias matriculadas para el estudiante Daniel Castillo:" + matriculas.MatriculasCount());

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura, por la funcion LongCount
Console.WriteLine("Cantidad de Materias matriculadas para el estudiante Daniel Castillo 'LongCount':" + matriculas.MatriculasLongCount());

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura, por la funcion Min
Console.WriteLine("Fecha menor de registro de matricula, registrada:" + matriculas.MatriculasMin());

//Imprime en consola todos los valores de la coleccion, filtrados por asignatura, por la funcion Max
Console.WriteLine("Fecha mayor de registro de matricula, registrada:" + matriculas.MatriculasMax());



