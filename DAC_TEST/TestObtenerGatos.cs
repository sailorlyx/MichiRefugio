using CapaACCESODATOS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace DAC_TEST
{
    [TestClass]
    public class TestObtenerGatos
    {
        [TestMethod]
        public void ObtenerMininos()
        {
                // Arrange
                var dataTableEsperado = new DataTable();
                dataTableEsperado.Columns.Add("id", typeof(int));
                dataTableEsperado.Columns.Add("nombre", typeof(string));
                dataTableEsperado.Columns.Add("edad", typeof(byte));
                dataTableEsperado.Columns.Add("genero", typeof(char));
                dataTableEsperado.Columns.Add("descripcion", typeof(string));
                dataTableEsperado.Columns.Add("adoptado", typeof(bool));
                dataTableEsperado.Columns.Add("foto", typeof(string));

                DataRow row1 = dataTableEsperado.NewRow();
                row1["id"] = 1;
                row1["nombre"] = "Sanson";
                row1["edad"] = 1;
                row1["genero"] = 'M';
                row1["descripcion"] = "Sansón es un gatito de 1 año y medio muy amoroso y dormilón. Lo encontramos solo en un descampado, era el único de su familia que habia podido sobrevivir. Sus cosas favoritas en este mundo son comer, dormir y jugar un poco de vez en cuando. ¿Hemos dicho ya que le gusta dormir? Está completamente sano, desparasitado y esterilizado.";
                row1["adoptado"] = false;
                row1["foto"] = "img/sanson/sansonprincipal.jpg";
                dataTableEsperado.Rows.Add(row1);

                var dataTableObtenido = DAC_GATO.ObtenerGatos();

                // Assert
                Assert.AreEqual(dataTableEsperado.Rows.Count, dataTableObtenido.Rows.Count);

                for (int i = 0; i < dataTableEsperado.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTableEsperado.Columns.Count; j++)
                    {
                        Assert.AreEqual(dataTableEsperado.Rows[i][j], dataTableObtenido.Rows[i][j]);
                    }
                }
            }
        }
    }