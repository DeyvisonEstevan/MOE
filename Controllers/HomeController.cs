using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using moe.Models;

namespace moe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            UsuarioRepository ur = new UsuarioRepository();
            ur.TestarConexao();
            return View();
        }

         public IActionResult Produtos()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contato(Contato novoContato)
        {
            InfoContatos.Incluir(novoContato);
            return View();
        }

        public IActionResult Mensagens()
        {
            List<Contato> listaContato = InfoContatos.Listar();
            return View(listaContato);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
