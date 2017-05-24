using Core;
using Diablos_Archives.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablos_Archives.Data
{
    public class PersonneServices
    {
        IRepository repo;

        public PersonneServices(IRepository repo)
        {
            this.repo = repo;
        }

        public void AddPersonne(Personne personne)
        {
            repo.Create(personne);
        }

        public void SaveChanges()
        {
            repo.Save();
        }

    }
}
