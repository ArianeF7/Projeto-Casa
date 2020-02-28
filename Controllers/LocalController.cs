using System;
using System.Linq;
using System.Threading.Tasks;
using CasaDeShow1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CasaDeShow1.Data;

namespace CasaDeShow1.Controllers
{
    public class LocalController : Controller
    {

        private readonly ApplicationDbContext dataBase;
        public LocalController(ApplicationDbContext dataBase){
            this.dataBase = dataBase;
        }

        [Authorize(Policy = "Adm")]
        public IActionResult Index(){
            var listarLocais = dataBase.Locais.ToList();
            return View(listarLocais);
        }
        
        [Authorize(Policy = "Adm")]
        public IActionResult Cadastrar(){
            return View();
        }

        [Authorize(Policy = "Adm")]
        public IActionResult Editar(int id){
            Local local = dataBase.Locais.First(registro => registro.Id == id);
            dataBase.SaveChanges();
            return View("Cadastrar", local);
        }

        [Authorize(Policy = "Adm")]
        public IActionResult Deletar(int id){
            Local local = dataBase.Locais.First(registro => registro.Id == id);            
            dataBase.Locais.Remove(local);
            dataBase.SaveChanges();
            return RedirectToAction("Index");
        }            

        [HttpPost]
        public IActionResult Salvar(Local local){
            if(local.Id == 0){
               //salvando novo local
                dataBase.Locais.Add(local);
            }else{
                //atualizando o local
                var localCadastrado = dataBase.Locais.First(registro => registro.Id == local.Id);
                localCadastrado.Nome = local.Nome;
                localCadastrado.Endereco = local.Endereco;
            }
            dataBase.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}