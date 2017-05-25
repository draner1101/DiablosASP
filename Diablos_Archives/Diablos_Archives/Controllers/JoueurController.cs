using AutoMapper;
using Core;
using Diablos_Archives.Data;
using Diablos_Archives.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diablos_Archives.Controllers
{
    public class JoueurController : Controller
    {
        DiablosDB context;
        EFRepository<DiablosDB> repository;
        JoueurServices service;

        public JoueurController()
        {
            context = new DiablosDB();
            repository = new EFRepository<DiablosDB>(context);
            service = new JoueurServices(repository);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                if (context != null)
                    context.Dispose();
            base.Dispose(disposing);

        }

        // GET: Joueur
        public ActionResult Index()
        {
            return View(service.ListeJoueur());
        }

        public ActionResult Ajouter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ajouter(JoueurViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View();

            Joueur joueur = Mapper.Map<Joueur>(viewModel);
            service.AddJoueur(joueur);
            repository.Save();

            return RedirectToAction("Index");
        }

        public ActionResult Modifier(int id)
        {
            Joueur model = service.GetJoueurById(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Modifier(JoueurViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View();


            Joueur joueur = Mapper.Map<Joueur>(viewModel);
            service.UpdateJoueur(joueur);
            repository.Save();

            return RedirectToAction("Index");
        }
    }
}