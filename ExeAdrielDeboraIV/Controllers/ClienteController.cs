using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExeAdrielDeboraIV.Models;

namespace ExeAdrielDeboraIV.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cadastrar()
        {
            ViewBag.Titulo = "Cadastre um Cliente";

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Cliente cliente) 
        {

            
            if (string.IsNullOrEmpty(cliente.NomeCLi))
            {
                ModelState.AddModelError("NomeCli", "O campo Nome é obrigatório");
                return View(cliente);
            }

            if (ModelState.IsValid)
            {
                return View("Resultado", cliente);
            }

            
            return View();
        }

        public ActionResult Resultado(Cliente cliente)
        {
            ViewBag.Titulo = "Cliente cadastrado";
            return View(cliente);
        }

        public ActionResult SelectCadastro(string login)
        {
            var dbExeAdrielDeboraIV = new Collection<string>
            {
                "Prático",
                "Heitor",
                "Cícero"

            };
            return Json(dbExeAdrielDeboraIV.All(a => a.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }



    }
}