using CursosOnline.Business;
using CursosOnline.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursosOnline.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<Cursos> modelCuros = new List<Cursos>();


            modelCuros = new CursosBo().dao.SelectAll();


            return View(modelCuros);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}