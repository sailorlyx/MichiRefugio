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

        public static void GuardarFormulario(FormularioModel formulario)
        {
            DAC_FORMULARIO.GuardarFormulario(formulario.nombre, formulario.apellido, formulario.apellido2, formulario.email, formulario.telefono, formulario.idGato);
        }

        //public static List<FormularioModel> EliminarFormulario()
        //{
        //    DataTable dt = DAC_FORMULARIO.EliminarFormulario();

        //    List<FormularioModel> lista = new List<FormularioModel>();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        lista.Add(new FormularioModel(row));
        //    }

        //    return lista;
        //}

    }
}