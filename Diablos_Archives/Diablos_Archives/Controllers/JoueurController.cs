using Core;
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
        // GET: Joueur
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ajouter()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Ajouter(JoueurViewModel joueur)
        {
            using (var context = new DiablosDB())
            {
                EFRepository<DiablosDB> repo = new EFRepository<DiablosDB>(context);
                
            }
            return View(joueur);
        }
    }
}