using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaACCESODATOS
{
    public class DAC_GATO
    {
        public static DataTable ObtenerGatos()
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, nombre, edad, genero, descripcion, adoptado, foto, Gusta, Odia "
                + " FROM GATO";
            return MetodosDatos.EjecutarComandoSelect(comando);
        }

        public static DataTable ObtenerGato(int id)
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "SELECT id, nombre, edad, genero, descripcion, adoptado, foto, Gusta, Odia"
                + " FROM GATO"
                + " WHERE id = " + id;
            return MetodosDatos.EjecutarComandoSelect(comando);
        }

        public static int ModificarGato(int id, string nombre, int edad, string genero, bool adoptado, string foto, string Gusta, string Odia)
        {
            SqlCommand comando = MetodosDatos.CrearComando();
            comando.CommandText = "UPDATE GATO SET nombre = @nombre, edad = @edad, genero = @genero, adoptado = @adoptado, foto = @foto, Gusta = @Gusta, Odia = @Odia "
               + " WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@edad", edad);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@adoptado", adoptado);
            comando.Parameters.AddWithValue("@foto", foto);
            comando.Parameters.AddWithValue("@Gusta", Gusta);
            comando.Parameters.AddWithValue("@Odia", Odia);

            return MetodosDatos.EjecutarComandoInsert(comando);

        }
    }
}
