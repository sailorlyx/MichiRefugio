using Microsoft.AspNetCore.Mvc;

namespace Vista.Controllers
{
    public class FormularioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Testuwu()
        {
            throw new Exception();
        }
    }
}
