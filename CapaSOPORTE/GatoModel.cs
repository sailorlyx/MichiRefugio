using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSOPORTE
{
    public class GatoModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public byte edad { get; set; }
        public string genero { get; set; }
        public string descripcion { get; set; }
        public bool adoptado { get; set; }
        public string foto { get; set; }

        public string Gusta { get; set; }
        public string Odia { get; set; }


        public GatoModel(DataRow row)
        {
            id = row.Field<int>("id");
            nombre = row.Field<string>("nombre");
            edad = row.Field<byte>("edad");
            genero = Utilidades.Genero(row.Field<string>("genero"));
            descripcion = row.Field<string>("descripcion");
            adoptado = Utilidades.TinyintABool(row.Field<byte>("adoptado"));
            foto = row.Field<string>("foto");
            Gusta = row.Field<string>("Gusta");
            Odia = row.Field<string>("Odia");
        }
    }
}
