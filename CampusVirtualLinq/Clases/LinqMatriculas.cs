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

        public LinqMatriculas()
        {
            using (StreamReader reader = new StreamReader("Matriculas.json"))
            {
                string json = reader.ReadToEnd();
                this.matriculasColection = System.Text.Json.JsonSerializer.Deserialize<List<Matriculas>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }

        public IEnumerable<Matriculas> MatriculasCollection()
        {
            return matriculasColection;
        }
        
        //Operador where
        public IEnumerable<Matriculas> MatriculasCalculo()
        {
            //Extension method
            //return matriculasColection.Where(p=> p.NombreAsignatura == "Calculo");
            //return matriculasColection.Where(p => p.SemestreInscripcion == 3 && p.Profesor == "Pedro Diaz");

            //Query method
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

        //Operador OrderBy
        public IEnumerable<Matriculas> MatriculasOrderBy()
        {
            //Extension method
            //return matriculasColection.Where(p => p.NombreAsignatura.Contains("C#")).OrderBy(p => p.Estudiante);

            //Extension method descending
            //OrderByDescending
            //return matriculasColection.Where(p => p.NombreAsignatura.Contains("C#")).OrderByDescending(p => p.Estudiante);

            //Query method
            //return from matriculas in matriculasColection
            //       where matriculas.NombreAsignatura == "C#"
            //       orderby matriculas.Estudiante
            //       select matriculas;

            //Query method descending
            //OrderByDescending
            return from matriculas in matriculasColection
                   where matriculas.NombreAsignatura == "C#"
                   orderby matriculas.Estudiante descending
                   select matriculas;
        }

        //Operador Take
        public IEnumerable<Matriculas> MatriculasTake()
        {
            //Extension method
            //return matriculasColection.Where(p => p.NombreAsignatura.Contains("C#")).Take(2);
            //return matriculasColection.Where(p => p.NombreAsignatura.Contains("C#")).TakeLast(2);

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

        //Operador Skip
        public IEnumerable<Matriculas> MatriculasSkip()
        {
            //Extension method
            //return matriculasColection.Where(p => p.NombreAsignatura.Contains("C#")).Skip(2);

            //Query method Take/Skip
            return (from matriculas in matriculasColection
                    where matriculas.NombreAsignatura == "C#"
                    orderby matriculas.Estudiante
                    select matriculas).Take(2).Skip(1);
        }

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

        //Operador Count
        public int MatriculasCount()
        {
            //Extension method
            // var count = matriculasColection.Count(p => p.EstudianteId == 1 && p.NombreAsignatura.Contains("C#"));
            //return count;

            //Query Count
            return (from matriculas in matriculasColection
                    where matriculas.EstudianteId == 1 && matriculas.NombreAsignatura == "C#"
                    orderby matriculas.Estudiante
                    select matriculas).Count();
        }

        public long MatriculasLongCount()
        {
            //Extension method
            var count = matriculasColection.LongCount(p => p.EstudianteId == 1 && p.NombreAsignatura.Contains("C#"));
            return count;

            //Query Count
            //return (from matriculas in matriculasColection
            //        where matriculas.EstudianteId == 1 && matriculas.NombreAsignatura == "C#"
            //        orderby matriculas.Estudiante
            //        select matriculas).Count();
        }
    }
}

