using System;
using System.Text;
using System.Data;

namespace INTRANET.objects
{
    public partial class SG_Sociedad
    {
        public int id_Sociedad { get; set; }
        public string descripcion { get; set; }
        public int estado { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_Sociedad = (dataReader["id_Sociedad"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Sociedad"]);
            this.descripcion = (dataReader["descripcion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["descripcion"]);
            this.estado = (dataReader["estado"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["estado"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
