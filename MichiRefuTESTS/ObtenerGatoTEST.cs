using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace MichiRefuTESTS
{
    [TestClass]
    public class PruebaObtenerGato
    {
        [TestMethod]
        public void TestObtenerGato()
        {
            int id = 1;

            DataTable resultado = CapaACCESODATOS.DAC_GATO.ObtenerGato(id);

            Assert.IsNotNull(resultado);
            Assert.AreEqual(1, resultado.Rows.Count);
            Assert.AreEqual("Sansón", resultado.Rows[0]["nombre"].ToString());
        }
    }
}