using System;
using System.Text;
using System.Data;

namespace INTRANET.objects
{
    public partial class SG_Logeo
    {        
        public string cod_Usuario { get; set; }
        public string password { get; set; }
        public int id_Sede { get; set; }
        public int estado { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.cod_Usuario = (dataReader["cod_Usuario"] == DBNull.Value) ? "" : Convert.ToString(dataReader["cod_Usuario"]);
            this.password = (dataReader["password"] == DBNull.Value) ? "" : Convert.ToString(dataReader["password"]);
            this.id_Sede = (dataReader["id_Sede"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Sede"]);
            this.estado = (dataReader["estado"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["estado"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
