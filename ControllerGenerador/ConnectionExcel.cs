using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerGenerador
{
    public class ConnectionExcel
    {
        public static OleDbConnection ConexionExcel()
        {
            string conexionExcel = string.Format("Provider = Microsoft.ACE.OLEDB 12.0; Data Source = {0}; Extends Properties = 'Excel 12.0' ");
            OleDbConnection connector = new OleDbConnection(conexionExcel);
            return connector;

        }
    }
}
