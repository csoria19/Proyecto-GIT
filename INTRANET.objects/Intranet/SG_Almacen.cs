using System;
using System.Text;
using System.Data;

namespace INTRANET.objects
{
    public partial class SG_Almacen
    {
        public int id_Almacen { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_Almacen = (dataReader["id_Almacen"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Almacen"]);
            this.codigo = (dataReader["codigo"] == DBNull.Value) ? "" : Convert.ToString(dataReader["codigo"]);
            this.descripcion = (dataReader["descripcion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["descripcion"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
