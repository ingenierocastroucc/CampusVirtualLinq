#region Documentación
/************************************************************************************************************
 * Propiedad intelectual de Pedro Castro
 ************************************************************************************************************                                                                 
 * Descripcion   : Clase usada como logica de negocio para la contencion de todos los operadores
 * 
 * Autor         : Pedro Castro                                                                                         
 * Fecha         : <25/07/2016>                                                                             
 *                                                                                                           
 * Fecha         Autor (Alias)      Modificación                                                               
 * ===========   ============       ========================================================================= 
 * 25/07/2016     Pedro Castro       1. Creación del LinqMatriculas
 * 26/07/2016     Pedro Castro       2. Se agregan operadores, el codigo comentado es perfectamente funcional 
 * se encunetra comentado dado que es un codigo didagtico, con la finalidad de dar a conocer las habilidades
 * del desarrollador y dado que solo se permite un return en la funcion
 * 30/07/2016     Pedro Castro       3. Refactor de codigo para obtener el menor numero de lineas comentadas, sin afectar la funcionalidad
 ***********************************************************************************************************/
#endregion Documentación

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusVirtualLinq.Clases
{
    public class LinqMatriculas
    {
        private List<Matriculas> matriculasColection = new List<Matriculas>();

        //Logica que obtiene data del .json
        public LinqMatriculas()
        {
            using (StreamReader reader = new StreamReader("Matriculas.json"))
            {
                string json = reader.ReadToEnd();
                this.matriculasColection = System.Text.Json.JsonSerializer.Deserialize<List<Matriculas>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }

        //Creacion de la coleccion
        public IEnumerable<Matriculas> MatriculasCollection()
        {
            return matriculasColection;
        }

        //Operador where extension method
        public IEnumerable<Matriculas> MatriculasCalculoExtensionMethod()
        {
            return matriculasColection.Where(p => p.SemestreInscripcion == 3 && p.Profesor == "Pedro Diaz");

        }

        //Operador where query method
        public IEnumerable<Matriculas> MatriculasCalculoQueryMethod()
        {
            return from matriculas in matriculasColection where matriculas.SemestreInscripcion == 3
            && matriculas.Profesor == "Pedro Diaz"
            select matriculas;
        }

        //Operador All
        public string MatriculasEstadoAll()
        {
            //Extension method
            var all = matriculasColection.Any(p => p.Estado != null && p.Estado != "");

            // Convertir el valor booleano a una cadena
            string resultado = all ? "Si" : "No";

            // Retornar el resultado como una cadena
            return resultado;
        }

        //Operador Any
        public string MatriculasEstadoAny()
        {
            //Extension method
            var any = matriculasColection.Any(p => p.SemestreInscripcion == 3);

            // Convertir el valor booleano a una cadena
            string resultado = any ? "Si" : "No";

            // Retornar el resultado como una cadena
            return resultado;
        }

        //Operador Contains
        public IEnumerable<Matriculas> MatriculasContains()
        {
            //Extension method
            return matriculasColection.Where(p => p.NombreAsignatura.Contains ("C#"));
        }

        //Operador OrderBy extension method
        public IEnumerable<Matriculas> MatriculasOrderByExtensionMethod()
        {
            //Extension method
            return matriculasColection.Where(p => p.NombreAsignatura.Contains("C#")).OrderBy(p => p.Estudiante);
        }

        //Operador OrderBy query method
        public IEnumerable<Matriculas> MatriculasOrderByQueryMethod()
        {
            //OrderByDescending
            return from matriculas in matriculasColection
                   where matriculas.NombreAsignatura == "C#"
                   orderby matriculas.Estudiante descending
                   select matriculas;
        }

        //Operador Take extension method
        public IEnumerable<Matriculas> MatriculasTakeExtensionMethod()
        {
            //Extension method
            return matriculasColection.Where(p => p.NombreAsignatura.Contains("C#")).Take(2);
            //return matriculasColection.Where(p => p.NombreAsignatura.Contains("C#")).TakeLast(2);

        }

        //Operador Take query method
        public IEnumerable<Matriculas> MatriculasTakeQueryMethod()
        {
            //Query method
            return (from matriculas in matriculasColection
                    where matriculas.NombreAsignatura == "C#"
                    orderby matriculas.Estudiante
                    select matriculas).Take(2);

        }

        //Operador TakeWhile
        public IEnumerable<Matriculas> MatriculasTakeWhile()
        {
            var fechaRegsitro = new DateTime(2024, 7, 23);
            //Extension method
            return matriculasColection.Where(p => p.NombreAsignatura.Contains("C#")).TakeWhile(p => p.FechaRegistro == fechaRegsitro);
        }

        //Operador Skip extension method
        public IEnumerable<Matriculas> MatriculasSkipExtensionMethod()
        {
            return matriculasColection.Where(p => p.NombreAsignatura.Contains("C#")).Skip(2);
        }

        //Operador Skip query method 
        public IEnumerable<Matriculas> MatriculasSkipQueryMethod()
        {
            //Take/Skip
            return (from matriculas in matriculasColection
                    where matriculas.NombreAsignatura == "C#"
                    orderby matriculas.Estudiante
                    select matriculas).Take(2).Skip(1);
        }

        //Operador select
        public IEnumerable<Matriculas> MatriculasSelect()
        {
            //Query method
            var resultado = matriculasColection.Select(p =>
                                                new Matriculas
                                                {
                                                    NombreAsignatura = p.NombreAsignatura,
                                                    Profesor = p.Profesor,
                                                    Estudiante = p.Estudiante
                                                }).ToList();
            // Ancho máximo de las columnas para alinear el texto
            int nombreAsignaturaWidth = resultado.Max(m => m.NombreAsignatura.Length) + 20; // +20 para algo de padding
            int profesorWidth = resultado.Max(m => m.Profesor.Length) + 5; // +5 para algo de padding
            int estudianteWidth = resultado.Max(m => m.Estudiante.Length) + 2; // +2 para algo de padding

            // Imprimir los encabezados de las columnas
            Console.WriteLine($"{"NombreAsignatura".PadRight(nombreAsignaturaWidth)}{"Profesor".PadRight(profesorWidth)}{"Estudiante".PadRight(estudianteWidth)}");

            // Imprimir una línea divisoria
            Console.WriteLine(new string('-', nombreAsignaturaWidth) + new string('-', profesorWidth) + new string('-', estudianteWidth));

            // Imprimir los resultados
            foreach (var item in resultado)
            {
                Console.WriteLine($"{item.NombreAsignatura.PadRight(nombreAsignaturaWidth)}{item.Profesor.PadRight(profesorWidth)}{item.Estudiante.PadRight(estudianteWidth)}");
            }

            return resultado;

        }

        //Operador Count query method
        public int MatriculasCount()
        {
            return (from matriculas in matriculasColection
                    where matriculas.EstudianteId == 1 && matriculas.NombreAsignatura == "C#"
                    orderby matriculas.Estudiante
                    select matriculas).Count();
        }

        //Operador LongCount extension method
        public long MatriculasLongCount()
        {
            var count = matriculasColection.LongCount(p => p.EstudianteId == 1 && p.NombreAsignatura.Contains("C#"));
            return count;
        }

        //Operador Min
        public string MatriculasMin()
        {
            //Extension method
            var fechaRegsitro = matriculasColection.Min(p => p.FechaRegistro.ToShortDateString());
            return fechaRegsitro;
        }

        //Operador Max
        public string MatriculasMax()
        {
            //Extension method
            var fechaRegsitro = matriculasColection.Max(p => p.FechaRegistro.ToShortDateString());
            return fechaRegsitro;
        }

        //Operador Sum
        public double MatriculasSum()
        {
            //Extension method
            var cantidaAsignatura = matriculasColection.Where(p => p.AsignaturaId == 2).Sum(p=>p.ValorMatricula);

            return cantidaAsignatura;
        }

        //Operador Average
        public double MatriculasAverage()
        {
            //Extension method

            var cantidaAsignatura = matriculasColection.Where(p => p.AsignaturaId == 2).Average(p => p.ValorMatricula);
            return cantidaAsignatura;
        }

        //Operador Aggregate
        public string MatriculasAggregate()
        {
            //Extension method

            var asignaturasMatriculadas = matriculasColection.Where(p => p.AsignaturaId == 2).Aggregate("", (AsignaturasMatriculas, next) =>
            {
                if (AsignaturasMatriculas != "")
                {
                    AsignaturasMatriculas += "\n" + next.DescripcionMatricula;
                }
                else 
                {
                    AsignaturasMatriculas += next.DescripcionMatricula;
                }
                return AsignaturasMatriculas;
            });
            return asignaturasMatriculadas;
        }
    }
}

