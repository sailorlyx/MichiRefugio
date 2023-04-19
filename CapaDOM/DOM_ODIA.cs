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
    public class DOM_ODIA
    {
            public static List<OdiaModel> ObtenerOdias()
            {
                DataTable dt = DAC_ODIA.ObtenerOdias();

                List<OdiaModel> lista = new List<OdiaModel>();

                foreach (DataRow row in dt.Rows)
                {
                    lista.Add(new OdiaModel(row));
                }

                return lista;
            }

            public static List<OdiaModel> ObtenerOdia(int id)
            {
                DataTable dt = DAC_ODIA.ObtenerOdia(id);

                List<OdiaModel> lista = new List<OdiaModel>();

                foreach (DataRow row in dt.Rows)
                {
                    lista.Add(new OdiaModel(row));
                }

                return lista;
            }
    
    }
}
