using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusVirtualLinq.Clases
{
    public class Matriculas
    {
        public Guid MatriculaId { get; set; }

        public Guid AsignaturaId { get; set; }

        public string NombreAsignatura { get; set; }

        public string Profesor { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string Url { get; set; }

        public string DescripcionMatricula { get; set; }

        public string Estado { get; set; }

        public int SemestreInscripcion { get; set; }

        public string [] Prioridad { get; set; }

        public string Estudiante { get; set; }

        public string EstudianteId { get; set; }


    }
}
