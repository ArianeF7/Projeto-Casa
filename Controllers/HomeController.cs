using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CasaDeShow1.Models;
using CasaDeShow1.Data;
using Microsoft.AspNetCore.Identity;

namespace CasaDeShow1.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ApplicationDbContext dataBase;
        private readonly ILogger<HomeController> _logger;

        //private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dataBase)
        {
            this.dataBase = dataBase;
            _logger = logger;
        }

        // public HomeController(SignInManager<IdentityUser> signInManager,
        //    UserManager<IdentityUser> userManager)
        // {
        //     //_userManager = userManager;
        //     _signInManager = signInManager;
        // }

        public IActionResult Index()
        {
            var listaLocais = dataBase.Locais.ToList();
            var listarEventos = dataBase.Eventos.ToList();
            return View(dataBase.Eventos.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
