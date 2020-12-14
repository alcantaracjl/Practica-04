using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsEscuelaEntidad
    {
        private int idEscuela;
        private String nombre;
        private int idFacultad;

        public int IdEscuela { get => idEscuela; set => idEscuela = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdFacultad { get => idFacultad; set => idFacultad = value; }
    }
}
