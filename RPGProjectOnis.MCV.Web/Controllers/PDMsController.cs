using RPGProjectOnis.Mdl;
using RPGProjectOnis.Svc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPGProjectOnis.MCV.Web.Controllers
{    
    public class PDMsController : Controller
    {
        SvcPDM _insSvcPDM = new SvcPDM();
        SvcClasses _insSvcClasses = new SvcClasses();
        // GET: PDMs
        public ActionResult Index()
        {
            //ViewBag.ValidacaoSucessVisib = "hidden";
            ViewBag.Msg = "";
            return View(_insSvcPDM.ListarPDMs());
        }

        // GET: PDMs/Details/5
        public ActionResult Details(int id)
        {
            return View(_insSvcPDM.encontraPDM(id));
        }

        // GET: PDMs/Create
        public ActionResult Create()
        {
            //ViewBag.ValidacaoSucessVisib = "hidden";
            //ViewBag.Msg = "";
            var listClasses = _insSvcClasses.ListarClasses();
            ViewBag.Classes = new SelectList(listClasses, "id", "nome");

            return View();
        }

        // POST: PDMs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PDM personagem)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add insert logic here
                    _insSvcPDM.addPDM(personagem);
                    return RedirectToAction("Index", _insSvcPDM.ListarPDMs());
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        // GET: PDMs/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_insSvcPDM.encontraPDM(id));
        }

        // POST: PDMs/Edit/5
        [HttpPost]
        public ActionResult Edit(PDM atPersonagem)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add delete logic here
                    _insSvcPDM.updatePDM(atPersonagem);
                    return RedirectToAction("Index", _insSvcPDM.ListarPDMs());
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        // GET: PDMs/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_insSvcPDM.encontraPDM(id));
        }

        //POST: PDMs/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            if (ModelState.IsValid)
            { 
                try
                {
                    // TODO: Add delete logic here
                    _insSvcPDM.deletePDM(id);
                    return RedirectToAction("Index", _insSvcPDM.ListarPDMs());
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }

        }
    }
}
