using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class ApSemana3Controller : Controller
    {
        //
        // GET: /ApSemana3/

        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /ApSemana3/Welcome/

        public string Welcome()
        {
            return "Bem vindo!";
        }
    }
}