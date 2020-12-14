using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadesW
{
    public class clsPeriodoEntidad
    {
        private int idPeriodo;
        private String nombre;

        public int IdPeriodo { get => idPeriodo; set => idPeriodo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
