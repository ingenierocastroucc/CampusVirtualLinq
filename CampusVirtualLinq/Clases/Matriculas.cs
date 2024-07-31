#region Documentación
/**************************************************************************************************
 * Propiedad intelectual de Pedro Castro.                                                           
 **************************************************************************************************
 * Descripcion   : Modelo para cargar obtencion de data del .json 
 * Autor         : Pedro Castro                                       
 * Fecha         : 25/07/2024 
 *                                                                                                           
 * Fecha          Autor                   Modificación                                                                 
 * ============   =====================   ========================================================= 
 * 25/07/2024      Pedro Castro           Creación inicial
 * 26/07/2024      Pedro Castro           Documentacion
***************************************************************************************************/
#endregion Documentación
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusVirtualLinq.Clases
{
    public class Matriculas
    {
        /// <summary>
        /// Propiedad para obtener el Id de la matricula registrada
        /// </summary>
        public int MatriculaId { get; set; }

        /// <summary>
        /// Propiedad para obtener el Id de la asignatura asociada a la matricula registrada
        /// </summary>
        public int AsignaturaId { get; set; }

        /// <summary>
        /// Propiedad para obtener el nombre de la Asignatura asociada a la matricula registrada
        /// </summary>
        public string NombreAsignatura { get; set; }

        /// <summary>
        /// Propiedad para obtener el profesor que dicta la asignatura asociada a la matricula registrada
        /// </summary>
        public string Profesor { get; set; }

        /// <summary>
        /// Propiedad para obtener el fecha de registro de la matricula
        /// </summary>
        public DateTime FechaRegistro { get; set; }

        /// <summary>
        /// Propiedad para obtener el ULR de la imagen publica de la asignatura de la matricula registrada
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Propiedad para obtener el descripcion de la matricula registrada
        /// </summary>
        public string DescripcionMatricula { get; set; }

        /// <summary>
        /// Propiedad para obtener el Estado de la matricula registrada
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// Propiedad para obtener el Semestre de inscripcion de la matricula registrada
        /// </summary>
        public int SemestreInscripcion { get; set; }

        /// <summary>
        /// Propiedad para obtener la prioridad de la matricula registrada
        /// </summary>
        public string [] Prioridad { get; set; }

        /// <summary>
        /// Propiedad para obtener el estudiante matriculado
        /// </summary>
        public string Estudiante { get; set; }

        /// <summary>
        /// Propiedad para obtener el Id del estudiante matriculado
        /// </summary>
        public int EstudianteId { get; set; }

        /// <summary>
        /// Propiedad para obtener el valor de la matricula
        /// </summary>
        public int ValorMatricula { get; set; }


    }
}
