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
    }
}

