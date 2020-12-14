using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaW
{
    public class clsAlumnoLogica
    {


        private static clsAlumnoLogica Cls = null;
        private clsAlumnoLogica() { }

        public static clsAlumnoLogica GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsAlumnoLogica();
            }
            return Cls;
        }

      

    }
}
