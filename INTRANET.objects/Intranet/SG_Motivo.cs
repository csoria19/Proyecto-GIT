using System;
using System.Text;
using System.Data;

namespace INTRANET.objects
{
    public partial class SG_Motivo
    {
        public int id_Motivo { get; set; }        
        public string descripcion { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_Motivo = (dataReader["id_Motivo"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Motivo"]);            
            this.descripcion = (dataReader["descripcion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["descripcion"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
