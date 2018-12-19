using System;
using System.Text;
using System.Data;

namespace INTRANET.objects.Intranet
{
    public partial class SG_Centro_Alm_Equipo
    {
        public int id_CAE { get; set; }
        public int id_Centro { get; set; }
        public int id_Almacen { get; set; }
        public int id_Equipo { get; set; }
        public string usuario_Creacion { get; set; }
        public DateTime fecha_Creacion { get; set; }
        public string usuario_Actualizacion { get; set; }
        public DateTime fecha_Actualizacion { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_CAE = (dataReader["id_CAE"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_CAE"]);
            this.id_Centro = (dataReader["id_Centro"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Centro"]);
            this.id_Almacen = (dataReader["id_Almacen"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Almacen"]);
            this.id_Equipo = (dataReader["id_Equipo"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Equipo"]);
            this.usuario_Creacion = (dataReader["usuario_Creacion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["usuario_Creacion"]);
            this.fecha_Creacion = (dataReader["fecha_Creacion"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dataReader["fecha_Creacion"]);
            this.usuario_Actualizacion = (dataReader["usuario_Actualizacion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["usuario_Actualizacion"]);
            this.fecha_Actualizacion = (dataReader["fecha_Actualizacion"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dataReader["fecha_Actualizacion"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
