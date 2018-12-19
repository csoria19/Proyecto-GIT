using System;
using System.Text;
using System.Data;

namespace INTRANET.objects
{
    public partial class SG_Area
    {
        public int id_Area { get; set; }
        public string descripcion { get; set; }
        public int id_Gerencia { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_Area = (dataReader["id_Area"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Area"]);
            this.descripcion = (dataReader["descripcion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["descripcion"]);
            this.id_Gerencia = (dataReader["id_Gerencia"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Gerencia"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
