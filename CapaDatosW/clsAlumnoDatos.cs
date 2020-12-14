using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatosW
{
    public class clsAlumnoDatos
    {


        private static clsAlumnoDatos Cls = null;
        private clsAlumnoDatos() { }

        public static clsAlumnoDatos GetInstance()
        {

            if (Cls == null)
            {
                Cls = new clsAlumnoDatos();
            }
            return Cls;
        }





      


    }
}
