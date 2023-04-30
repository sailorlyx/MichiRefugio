using CapaACCESODATOS;
using CapaSOPORTE;
using System.Data;

namespace CapaDOM
{
    public class DOM_FORMULARIO
    {
        public static List<FormularioModel> ObtenerFormularios()
        {
            DataTable dt = DAC_FORMULARIO.ObtenerFormularios();

            List<FormularioModel> lista = new List<FormularioModel>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new FormularioModel(row));
            }

            return lista;
        }
    }
}