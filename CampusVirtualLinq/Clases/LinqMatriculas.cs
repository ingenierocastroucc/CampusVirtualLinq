﻿using System;
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
    }
}

