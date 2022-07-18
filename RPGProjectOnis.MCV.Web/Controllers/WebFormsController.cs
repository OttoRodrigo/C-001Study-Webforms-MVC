using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPGProjectOnis.MCV.Web.Controllers
{
    public class WebFormsController : Controller
    {
        // GET: WebForms
        public ActionResult listaPersonagens()
        {
            return View("C:/Users/Otto_/source/repos/RPGProject/RPGProjectOnis.Web.WF/ListarPersonagemPage.aspx");
        }

        public ActionResult criarPersonagem()
        {
            return View("C:/Users/Otto_/source/repos/RPGProject/RPGProjectOnis.Web.WF/CriarPersonagemPage.aspx");
        }
    }
}