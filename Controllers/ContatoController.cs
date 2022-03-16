using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using moe.Models;
namespace moe.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Mensagens(){
            if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login","Usuario");
            }
            ContatoRepository cr= new ContatoRepository();
            List<Contato> listagem = cr.Listar();
            return View(listagem);
        }

        public IActionResult Contato(){
            return View();
        }
        
        [HttpPost]
        public IActionResult Contato(Contato user){
            ContatoRepository cr = new ContatoRepository();
            cr.Inserir(user);
            ViewBag.Mensagem = "Mensagem realizada com sucesso!";
            return View();
        }  
    }
}