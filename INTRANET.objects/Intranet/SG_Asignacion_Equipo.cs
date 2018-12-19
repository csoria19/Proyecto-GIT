using System;
using System.Text;
using System.Data;

namespace INTRANET.objects
{
    public partial class SG_Asignacion_Equipo
    {        
        public int id_Asignacion { get; set; }
        public int id_Equipo { get; set; }
        //public int id_Equipo { get; set; }
        public DateTime fecha_Registro { get; set; }
        public string indicar_Movimiento { get; set; }
        public int id_Motivo { get; set; }
        public int id_Centro { get; set; }
        public int id_Ubicacion { get; set; }
        public int id_Zona { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {            
            this.id_Asignacion = (dataReader["id_Asignacion"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Asignacion"]);
            this.id_Equipo = (dataReader["id_Equipo"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Equipo"]);
            this.fecha_Registro = (dataReader["fecha_Registro"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dataReader["fecha_Registro"]);
            this.indicar_Movimiento = (dataReader["indicar_Movimiento"] == DBNull.Value) ? "" : Convert.ToString(dataReader["indicar_Movimiento"]);
            this.id_Motivo = (dataReader["id_Motivo"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Motivo"]);
            this.id_Centro = (dataReader["id_Centro"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Centro"]);
            this.id_Ubicacion = (dataReader["id_Ubicacion"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Ubicacion"]);
            this.id_Zona = (dataReader["id_Zona"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Zona"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
