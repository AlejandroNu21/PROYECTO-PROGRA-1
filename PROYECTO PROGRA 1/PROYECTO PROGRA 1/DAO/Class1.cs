using PROYECTO_PROGRA_1.MODEL;
using PROYECTO_PROGRA_1.VISTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PROGRA_1.DAO
{
    class Class1
    {
        public List<Tbl_UserList1> cargarDatosuserlist()
        {
            List<Tbl_UserList1> Lista;

            using (DATOSPROYECTOEntities1 db = new DATOSPROYECTOEntities1())
            {
                Lista = db.Tbl_UserList1();
            }

            return Lista;
        }


    }
    
}
