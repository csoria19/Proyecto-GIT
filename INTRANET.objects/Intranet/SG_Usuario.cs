using System;
using System.Text;
using System.Data;

namespace INTRANET.objects
{
    public partial class SG_Usuario
    {
        public int id_Usuario { get; set; }
        public string cod_Sap { get; set; }
        public string cod_Usuario { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public int id_Cargo { get; set; }
        public int id_Sociedad { get; set; }
        public int id_Gerencia { get; set; }
        public int id_Area { get; set; }
        public int id_Centro { get; set; }
        public int id_Ubicacion { get; set; }
        public string estado { get; set; }
        public string correo { get; set; }
        public int tipo_Menu { get; set; }
        public string usuario_Creacion { get; set; }
        public DateTime fecha_Creacion { get; set; }
        public string usuario_Actualizacion { get; set; }
        public DateTime fecha_Actualizacion { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_Usuario = (dataReader["id_Usuario"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Usuario"]);
            this.cod_Sap = (dataReader["cod_Sap"] == DBNull.Value) ? "" : Convert.ToString(dataReader["cod_Sap"]);
            this.cod_Usuario = (dataReader["cod_Usuario"] == DBNull.Value) ? "" : Convert.ToString(dataReader["cod_Usuario"]);
            this.nombre = (dataReader["nombre"] == DBNull.Value) ? "" : Convert.ToString(dataReader["nombre"]);
            this.apellidoPaterno = (dataReader["apellidoPaterno"] == DBNull.Value) ? "" : Convert.ToString(dataReader["apellidoPaterno"]);
            this.apellidoMaterno = (dataReader["apellidoMaterno"] == DBNull.Value) ? "" : Convert.ToString(dataReader["apellidoMaterno"]);
            this.id_Cargo = (dataReader["id_Cargo"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Cargo"]);
            this.id_Sociedad = (dataReader["id_Sociedad"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Sociedad"]);
            this.id_Gerencia = (dataReader["id_Gerencia"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Gerencia"]);
            this.id_Area = (dataReader["id_Area"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Area"]);
            this.id_Centro = (dataReader["id_Centro"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Centro"]);
            this.id_Ubicacion = (dataReader["id_Ubicacion"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Ubicacion"]);
            this.estado = (dataReader["estado"] == DBNull.Value) ? "" : Convert.ToString(dataReader["estado"]);
            this.correo = (dataReader["correo"] == DBNull.Value) ? "" : Convert.ToString(dataReader["correo"]);
            this.tipo_Menu = (dataReader["tipo_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["tipo_Menu"]);
            this.usuario_Creacion = (dataReader["usuario_Creacion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["usuario_Creacion"]);
            this.fecha_Creacion = (dataReader["fecha_Creacion"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dataReader["fecha_Creacion"]);
            this.usuario_Actualizacion = (dataReader["usuario_Actualizacion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["usuario_Actualizacion"]);
            this.fecha_Actualizacion = (dataReader["fecha_Actualizacion"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dataReader["fecha_Actualizacion"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }

    }

}
