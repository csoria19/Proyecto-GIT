using System;
using System.Text;
using System.Data;

namespace INTRANET.objects
{
    public partial class SG_Tipo_Adquision
    {
        public int id_TipoAdquision { get; set; }        
        public string descripcion { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_TipoAdquision = (dataReader["id_TipoAdquision"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_TipoAdquision"]);            
            this.descripcion = (dataReader["descripcion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["descripcion"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
