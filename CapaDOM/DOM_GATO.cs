using CapaACCESODATOS;
using CapaSOPORTE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDOM
{
    public class DOM_GATO
    {
        public static List<GatoModel> ObtenerGatos()
        {
            DataTable dt = DAC_GATO.ObtenerGatos();

            List<GatoModel> lista = new List<GatoModel>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new GatoModel(row));
            }

            return lista;
        }

        public static List<GatoModel> ObtenerGato(int id)
        {
            DataTable dt = DAC_GATO.ObtenerGato(id);

            List<GatoModel> lista = new List<GatoModel>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new GatoModel(row));
            }

            return lista;
        }
    }
}
