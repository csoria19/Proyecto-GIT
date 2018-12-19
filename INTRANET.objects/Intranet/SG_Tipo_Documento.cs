using System;
using System.Text;
using System.Data;


namespace INTRANET.objects
{
    public partial class SG_Tipo_Documento
    {
        public int id_TipoDocumento { get; set; }
        public string codigo_Documento { get; set; }
        public string descripcion { get; set; }        
        public int id_Menu { get; set; }

        public void readData(IDataReader dataReader)
        {
            this.id_TipoDocumento = (dataReader["id_TipoDocumento"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_TipoDocumento"]);
            this.codigo_Documento = (dataReader["codigo_Documento"] == DBNull.Value) ? "" : Convert.ToString(dataReader["codigo_Documento"]);
            this.descripcion = (dataReader["descripcion"] == DBNull.Value) ? "" : Convert.ToString(dataReader["descripcion"]);            
            this.id_Menu = (dataReader["id_Menu"] == DBNull.Value) ? 0 : Convert.ToInt32(dataReader["id_Menu"]);
        }
    }
}
