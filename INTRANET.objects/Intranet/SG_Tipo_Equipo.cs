using System;
using System.Text;
using System.Data;

namespace INTRANET.objects
{
    public partial class SG_Tipo_Equipo
    {
        public int id_TipoEquipo { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public string detalle { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_TipoEquipo = (dataReader["id_TipoEquipo"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_TipoEquipo"]);
            this.codigo = (dataReader["codigo"] == DBNull.Value) ? "" : Convert.ToString(dataReader["codigo"]);
            this.descripcion = (dataReader["descripcion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["descripcion"]);
            this.detalle = (dataReader["detalle"] == DBNull.Value) ? "" : Convert.ToString(dataReader["detalle"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
