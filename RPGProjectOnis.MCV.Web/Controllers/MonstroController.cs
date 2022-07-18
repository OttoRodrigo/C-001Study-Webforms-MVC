using RPGProjectOnis.Mdl;
using RPGProjectOnis.Svc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPGProjectOnis.MCV.Web.Controllers
{
    public class MonstroController : Controller
    {
        SvcPDM _insSvcPDM = new SvcPDM();


        // GET: CriarMonstro
        public ActionResult Index()
        {
            return View("criarMonstro");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult criaPDM([Bind(Exclude = "id")] PDM dados)
        {
            if (ModelState.IsValid)
            {
                //Faz Inserção
                //
                return View("criarMonstro");
            }
            else
            {
                return View("criarMonstro", dados);
            }

            //persPDM.nome = form.
            //_insSvcPDM.criaPDM(PDM);


        }

        public ActionResult ddlRacas()
        {
            SvcRacas racas = new SvcRacas();
            var listaracas = racas.ListarRacas();
            if(listaracas != null)
            {
                ViewBag.racas = listaracas;
            }
            return View("criarMonstro");
        }


        public ActionResult listarMontros()
        {
            return View("listaMonstros");
        }
    }
}