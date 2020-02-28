using System;
using System.Linq;
using System.Threading.Tasks;
using CasaDeShow1.Data;
using CasaDeShow1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CasaDeShow1.Controllers
{
    public class EventoController : Controller
    {

        private readonly ApplicationDbContext dataBase;
        public EventoController(ApplicationDbContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public IActionResult Index()
        {
            var listaLocais = dataBase.Locais.ToList();
            var listarEventos = dataBase.Eventos.ToList();
            return View(dataBase.Eventos.ToList());
        }

        [Authorize(Policy = "Adm")]
        public IActionResult Cadastrar()
        {      
           
                ViewBag.Local = dataBase.Locais.ToList();
                return View();
                       
        }

        [Authorize(Policy = "Adm")]
        public IActionResult Editar(int id)
        {
            ViewBag.Local = dataBase.Locais.ToList();
            Evento evento = dataBase.Eventos.First(registroEvento => registroEvento.Id == id);
            dataBase.SaveChanges();
            return View("Cadastrar", evento);
        }

        public IActionResult Deletar(int id)
        {
            Evento evento = dataBase.Eventos.First(registroEvento => registroEvento.Id == id);
            dataBase.Eventos.Remove(evento);
            dataBase.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Salvar(Evento evento)
        {
            //  if (!ModelState.IsValid)
            //  {
            //         ViewBag.Local = dataBase.Eventos.Local.ToList();
            //         evento.Local = dataBase.Locais.First(registroLocal => registroLocal.Id == evento.Local.Id);
            //                     //     
            // // //     ViewBag.Local = dataBase.Locais.ToList();
            //         return View("Cadastrar", evento);            

            //  }
            
            
            if (evento.Id == 0)
            {
                //salvando novo local
                evento.Local = dataBase.Locais.First(registroLocal => registroLocal.Id == evento.Local.Id);
                dataBase.Eventos.Add(evento);
                //ViewBag.Local = dataBase.Eventos.Local.ToList();
            }
            else
            {
                //atualizando o local
                var eventoCadastrado = dataBase.Eventos.First(registroEvento => registroEvento.Id == evento.Id);
                eventoCadastrado.Nome = evento.Nome;
                eventoCadastrado.Capacidade = evento.Capacidade;
                eventoCadastrado.preco = evento.preco;
                eventoCadastrado.categoria = evento.categoria;
                eventoCadastrado.Local = dataBase.Locais.First(registroLocal => registroLocal.Id == evento.Local.Id);
                //ViewBag.Local = dataBase.Eventos.Local.ToList();
            }
            ViewBag.Local = dataBase.Eventos.Local.ToList();
            dataBase.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
