using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaSOPORTE
{
    public class Listas
    {
        public List<GatoModel> listaGatos { get; set; }
        public List<UsuarioModel> listaUsuarios { get; set; }
        public List<FormularioModel> listaFormularios { get; set; }
        public FormularioModel formularioUsu { get; set; }

        public Listas()
        {
            formularioUsu = new FormularioModel();
        }
    }
}
