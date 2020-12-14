using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsMatriculaEntidad
    {
        private int idMatricula;
        private String codAlumno;
        private int idPeriodo;
        private int idCiclo;
        private DateTime fecha;
        private String estado;

        public int IdMatricula { get => idMatricula; set => idMatricula = value; }
        public string CodAlumno { get => codAlumno; set => codAlumno = value; }
        public int IdPeriodo { get => idPeriodo; set => idPeriodo = value; }
        public int IdCiclo { get => idCiclo; set => idCiclo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
