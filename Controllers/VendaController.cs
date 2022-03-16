using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using moe.Models;
namespace moe.Controllers
{
    public class VendaController : Controller
    {

        public IActionResult Editar(int IdVenda){
            VendaRepository vr= new VendaRepository();
            Venda vendaLocalizada = vr.BuscarPorId(IdVenda);
            return View(vendaLocalizada);
        }

        [HttpPost]
        public IActionResult Editar(Venda user){
            VendaRepository vr= new VendaRepository();
            vr.Alterar(user);
            return RedirectToAction("Carrinho","Venda");
        }

        public IActionResult Remover(int IdVenda){
            VendaRepository vr= new VendaRepository();
            Venda vendaLocalizada = vr.BuscarPorId(IdVenda);
            vr.Excluir(vendaLocalizada);
            return RedirectToAction("Carrinho","Venda");
        }

        public IActionResult Carrinho(){
            if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login","Usuario");
            }
            VendaRepository vr= new VendaRepository();
            List<Venda> listagem = vr.Listar();
            return View(listagem);
        }

        public IActionResult Adicionar(){
            return View();
        }
        
        [HttpPost]
        public IActionResult Adicionar(Venda user){
            VendaRepository vr = new VendaRepository();
            vr.Inserir(user);
            ViewBag.Mensagem = "produto adicionado com sucesso!";
            return View();
        }
    }
}