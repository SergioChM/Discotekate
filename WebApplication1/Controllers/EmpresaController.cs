using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmpresaController : Controller
    {
        public ActionResult Listado()
        {
            var modelo = new Empresamodel();
            var evento = modelo.ListadoEmpresa();
            ViewBag.ListadoEmpresa = evento;

            return View();
        }
    }
}