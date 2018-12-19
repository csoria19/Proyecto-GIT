using System;
using System.Text;
using System.Data;

namespace INTRANET.objects
{
    public partial class SG_Cargo
    {
        public int id_Cargo { get; set; }
        public string descripcion { get; set; }
        public int estado { get; set; }
        public int id_Area { get; set; }
        public int tipo_Menu { get; set; }
        public int id_Gerencia { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_Cargo = (dataReader["id_Cargo"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Cargo"]);
            this.descripcion = (dataReader["descripcion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["descripcion"]);
            this.estado = (dataReader["estado"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["estado"]);
            this.id_Area = (dataReader["id_Area"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Area"]);
            this.tipo_Menu = (dataReader["tipo_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["tipo_Menu"]);
            this.id_Gerencia = (dataReader["id_Gerencia"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Gerencia"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
