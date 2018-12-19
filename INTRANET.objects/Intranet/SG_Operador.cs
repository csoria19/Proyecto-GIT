using System;
using System.Text;
using System.Data;

namespace INTRANET.objects
{
    public partial class SG_Operador
    {
        public int id_Operador { get; set; }
        public string descripcion { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_Operador = (dataReader["id_Operador"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Operador"]);
            this.descripcion = (dataReader["descripcion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["descripcion"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
