//using CapaSOPORTE;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Data.SqlClient;

//namespace Vista.Controllers
//{
//    public class InicioSesionController : Controller
//    {
//        [HttpPost]
//        public ActionResult IniciarSesion(UsuarioModel usuario)
//        {
//            if (ModelState.IsValid)
//            {
//                string connectionString = "Data Source=LAPTOP-GGTKFVHF\\SQLEXPRESS;Initial Catalog=MichiDB;Integrated Security=True";
//                using (SqlConnection connection = new SqlConnection(connectionString))
//                {
//                    string query = "SELECT * FROM Usuarios WHERE email=@email AND contraseña=@contraseña";
//                    SqlCommand command = new SqlCommand(query, connection);
//                    command.Parameters.AddWithValue("@email", usuario.email);
//                    command.Parameters.AddWithValue("@contraseña", usuario.contraseña);

//                    connection.Open();
//                    SqlDataReader reader = command.ExecuteReader();

//                    if (reader.HasRows)
//                    {
//                        reader.Read();
//                        HttpContext.Session.Set("Usuario", System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(new UsuarioModel(reader)));

//                        reader.Close();
//                        connection.Close();

//                        return RedirectToAction("Index", "Home");
//                    }
//                    else
//                    {
//                        reader.Close();
//                        connection.Close();

//                        ModelState.AddModelError("", "Correo electrónico o contraseña incorrecta");
//                    }
//                }
//            }

//            return View("Index", usuario);
//        }
//    }
//}
