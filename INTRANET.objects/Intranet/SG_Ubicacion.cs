using System;
using System.Text;
using System.Data;

namespace INTRANET.objects
{
    public partial class SG_Ubicacion
    {
        public int id_Ubicacion { get; set; }
        public string descripcion { get; set; }
        public int id_Centro { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_Ubicacion = (dataReader["id_Ubicacion"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Ubicacion"]);
            this.descripcion = (dataReader["descripcion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["descripcion"]);
            this.id_Centro = (dataReader["id_Centro"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Centro"]);           
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }

    }
}
