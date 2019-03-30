using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Prova.Controllers.Usuario
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Verificar([FromForm] Dictionary <string,string> dados)
        {
            Models.Usuario u = new Models.Usuario(dados["login"],dados["senha"]);
           // bool ok = u.verificar(dados["login"], dados["senha"]);
            return null;
        }
    }
}