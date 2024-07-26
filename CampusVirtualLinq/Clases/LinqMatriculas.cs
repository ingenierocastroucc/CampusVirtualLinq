using System;
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
    }
}

