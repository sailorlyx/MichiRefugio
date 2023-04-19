using CapaACCESODATOS;
using CapaSOPORTE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ESTABA EL SEÑOR DOM GAAAATOOOO
namespace CapaDOM
{
    public class DOM_GUSTA
    {
        public static List<GustaModel> ObtenerGustas()
        {
            DataTable dt = DAC_GUSTA.ObtenerGustas();

            List<GustaModel> lista = new List<GustaModel>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new GustaModel(row));
            }

            return lista;
        }

        public static List<GustaModel> ObtenerGusta(int id)
        {
            DataTable dt = DAC_GUSTA.ObtenerGusta(id);

            List<GustaModel> lista = new List<GustaModel>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new GustaModel(row));
            }

            return lista;
        }
        public static List<GustaModel> ObtenerGustaGato(int id)
        {
            DataTable dt = DAC_GUSTA.ObtenerGustaGato(id);

            List<GustaModel> lista = new List<GustaModel>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new GustaModel(row));
            }

            return lista;
        }

    }
}
