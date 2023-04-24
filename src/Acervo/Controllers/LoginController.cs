using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Acervo.Models;


namespace Acervo.Controllers
{    public class LoginController : Controller
    {

        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Logar(Usuario usuarios)
        {
            try 
            {
                if (ModelState.IsValid)
                {
                    if (usuarios.Nome == "adm" && usuarios.Senha =="123")
                    {
                        return RedirectToAction("Index","Home");
                    }
                    TempData["MenagemErro"] = "Não foi possivel efetuar o login, verifique suas credenciais.";
                }
                return View("Index");
            }
            catch (Exception erro)
            {
            TempData["MenagemErro"] = "Não foi possivel efetuar o login, verifique suas credenciais: {erro.Message}";
            return RedirectToAction("Index");
            }
        }
    }
}