using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsClasesEntidad
    {
        private int idclases;
        private int idHorario;
        private int idCurso;
        private int idSeccion;
        private int vacantes;
        private String estado;
        private int iddocente;

        public int Idclases { get => idclases; set => idclases = value; }
        public int IdHorario { get => idHorario; set => idHorario = value; }
        public int IdCurso { get => idCurso; set => idCurso = value; }
        public int IdSeccion { get => idSeccion; set => idSeccion = value; }
        public int Vacantes { get => vacantes; set => vacantes = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Iddocente { get => iddocente; set => iddocente = value; }
    }
}
