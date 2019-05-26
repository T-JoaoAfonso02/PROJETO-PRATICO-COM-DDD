using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RM.Application.ViewModels;
using RM.Presentation.UI.Models;
using RM.Application.Interfaces;

namespace RM.Presentation.UI.Controllers
{
    public class TransportadoraController : Controller
    {
        private readonly ITransportadoraApplication _transportadoraApplication;
        public TransportadoraController(ITransportadoraApplication transportadoraApplication)
        {
            _transportadoraApplication = transportadoraApplication;
        }
        public ActionResult Index()
        {
            return View(_transportadoraApplication.ObterTransportadorasAtivas());
        }
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var transportadoraViewModel = _transportadoraApplication.ObterTransportadoraPorId(id.Value);
            if (transportadoraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(transportadoraViewModel);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransportadoraViewModel transportadoraViewModel)
        {
            if (ModelState.IsValid)
            {
                _transportadoraApplication.Adicionar(transportadoraViewModel);
                return RedirectToAction("Index");
            }

            return View(transportadoraViewModel);
        }
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var transportadoraViewModel = _transportadoraApplication.ObterTransportadoraPorId(id.Value);
            if (transportadoraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(transportadoraViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TransportadoraViewModel transportadoraViewModel)
        {
            if (ModelState.IsValid)
            {
                _transportadoraApplication.Atualizar(transportadoraViewModel);
                return RedirectToAction("Index");
            }
            return View(transportadoraViewModel);
        }
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var transportadoraViewModel = _transportadoraApplication.ObterTransportadoraPorId(id.Value);
            if (transportadoraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(transportadoraViewModel);
        }

        // POST: Transportadora/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _transportadoraApplication.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _transportadoraApplication.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
