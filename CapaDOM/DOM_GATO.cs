using CapaACCESODATOS;
using CapaSOPORTE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//estaba el señor dom gaaaatoooo

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

        public static GatoModel ModificarGato(GatoModel miau)
        {
            DAC_GATO.ModificarGato(miau.id, miau.nombre, miau.edad, miau.genero, miau.adoptado, miau.foto, miau.Gusta, miau.Odia);
            return miau;
        }

        //public static List<GatoModel> EliminarGato()
        //{
        //    DataTable dt = DAC_GATO.EliminarGato();

        //    List<GatoModel> lista = new List<GatoModel>();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        lista.Remove(new GatoModel(row));
        //    }

        //    return lista;
        //}
    }
}
