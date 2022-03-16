using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using moe.Models;
namespace moe.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login(){
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(Usuario user){
           UsuarioRepository ur= new UsuarioRepository();
           Usuario userEncontrado = ur.ValidarLogin(user);
           if(userEncontrado ==null){
               ViewBag.Mensagem = "Falha no Login!";
               return View();
           }
           else{
               HttpContext.Session.SetInt32("IdUsuario",userEncontrado.IdUsuario);
               HttpContext.Session.SetString("NomeUsuario",userEncontrado.Nome);
               return RedirectToAction("Lista","Usuario");
           }
           
       }

       public IActionResult Logout(){
           HttpContext.Session.Clear();
           return View("Login");
       }

       public IActionResult Editar(int IdUsuario){
           UsuarioRepository ur= new UsuarioRepository();
           Usuario userLocalizado = ur.BuscarPorId(IdUsuario);
           return View(userLocalizado);
       }

       [HttpPost]
        public IActionResult Editar(Usuario user){
           UsuarioRepository ur= new UsuarioRepository();
           ur.Alterar(user);
           return RedirectToAction("Lista","Usuario");
       }

       public IActionResult Remover(int IdUsuario){
           UsuarioRepository ur= new UsuarioRepository();
           Usuario userLocalizado = ur.BuscarPorId(IdUsuario);
           ur.Excluir(userLocalizado);
           return RedirectToAction("Lista","Usuario");
       }
       
        public IActionResult Lista(){
            if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login","Usuario");
            }
            UsuarioRepository ur= new UsuarioRepository();
            List<Usuario> listagem = ur.Listar();
            return View(listagem);
        }
        public IActionResult Cadastro(){
            return View();
        }
        
        [HttpPost]
        public IActionResult Cadastro(Usuario user){
            UsuarioRepository ur = new UsuarioRepository();
            ur.Inserir(user);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            return View();
        }
    }

}