using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CasaDeShow1.Data;
using CasaDeShow1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CasaDeShow1.Controllers
{
    public class CompraController : Controller
    {
        private readonly ApplicationDbContext dataBase;
        public CompraController(ApplicationDbContext dataBase)
        {
            this.dataBase = dataBase;
        }

         public IActionResult Index()
        {
            var listaLocais = dataBase.Locais.ToList();
            var listarEventos = dataBase.Eventos.ToList();
            var listaCompras = dataBase.Compras.ToList();
            return View(dataBase.Eventos.ToList());
        }

        public IActionResult Historico()
        {
            var listaLocais = dataBase.Locais.ToList();
            var listarEventos = dataBase.Eventos.ToList();

            var IdUsuario = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            ViewBag.Local = dataBase.Locais.ToList();   

            //return View("Historico", compra);
            return View(dataBase.Compras.Where(U => U.IdentityUser.Id == IdUsuario).ToList());
        }

        public IActionResult Cadastrar(int id)
        {             
                ViewBag.Local = dataBase.Locais.ToList();
                ViewBag.Evento = dataBase.Eventos.ToList();
                Comprar compra = dataBase.Compras.First(registroCompra => registroCompra.Id == id);

                return View();                       
        }

        public IActionResult comprar(int id)
        {
            ViewBag.Local = dataBase.Locais.ToList();
            Comprar compra = new Comprar();
            compra.Evento = dataBase.Eventos.First(registroCompra => registroCompra.Id == id);
            //Comprar compra = dataBase.Compras.First(registroCompra => registroCompra.Id == id);
           
            return View("Cadastrar", compra);
        }

        public IActionResult Salvar(Comprar compra)
        {
                //salvando novo local   
                compra.Evento = dataBase.Eventos.First(registroCompra => registroCompra.Id == compra.Evento.Id); 

                
                //retirando ingressos comprados da capacidade do evento
                var CapacEvento = dataBase.Eventos.First(q => q.Id == compra.Evento.Id);       
                CapacEvento.Capacidade -= compra.Quantidade;
                compra.TotalCompra = CapacEvento.preco * compra.Quantidade;                  

                compra.IdentityUser.Id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                compra.IdentityUser = dataBase.Users.First (RegistroUser => RegistroUser.Id == compra.IdentityUser.Id); 

                dataBase.Compras.Add(compra);
                dataBase.SaveChanges();             
              
                //ViewBag.Local = dataBase.Eventos.Local.ToList();
                return RedirectToAction("Historico", compra);
        
        }
    }
}