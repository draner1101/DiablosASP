using Core;
using Diablos_Archives.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablos_Archives.Data
{
    public class JoueurServices
    {
        IRepository repo;

        public JoueurServices(IRepository repo)
        {
            this.repo = repo;
        }

        public void AddJoueur(Joueur joueur)
        {
            repo.Create(joueur);
        }

        public Joueur GetJoueurById(int id)
        {
            return repo.GetById<Joueur>(id);
        }

        public IEnumerable<Joueur> ListeJoueur()
        {
            return repo.GetAll<Joueur>();
        }

        public void UpdateJoueur(Joueur joueur)
        {
            repo.Update<Personne>(joueur.Personne);
            repo.Update<Joueur>(joueur);
        }

    }
}
