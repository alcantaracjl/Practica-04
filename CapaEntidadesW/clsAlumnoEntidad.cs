using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsAlumnoEntidad
    {
        private String codAlumno;
        private int idEscuela;
        private int idPeriodo;
        private String idusuario;

        public string CodAlumno { get => codAlumno; set => codAlumno = value; }
        public int IdEscuela { get => idEscuela; set => idEscuela = value; }
        public int IdPeriodo { get => idPeriodo; set => idPeriodo = value; }
        public string Idusuario { get => idusuario; set => idusuario = value; }
    }
}
