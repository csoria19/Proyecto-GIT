using System;
using System.Text;
using System.Data;


namespace INTRANET.objects
{
    public partial class SG_Modelo
    {
        public int id_Modelo { get; set; }
        public int id_Marca { get; set; }
        public string descripcion { get; set; }
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_Modelo = (dataReader["id_Modelo"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Modelo"]);
            this.id_Marca = (dataReader["id_Marca"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Marca"]);
            this.descripcion = (dataReader["descripcion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["descripcion"]);
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
