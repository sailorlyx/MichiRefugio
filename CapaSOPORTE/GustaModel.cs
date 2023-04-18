using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSOPORTE
{
    public class GustaModel
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public GustaModel(DataRow row)
        {
            id = row.Field<int>("id");
            descripcion = row.Field<string>("descripcion");
        }
    }
}
