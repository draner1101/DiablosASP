using Core;
using Diablos_Archives.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablos_Archives.Data
{
    public class ProvinceServices
    {
        IRepository repo;

        public ProvinceServices(IRepository repo)
        {
            this.repo = repo;
        }

        public void AddJoueur(Province province)
        {
            repo.Create(province);
        }

        public Province GetJoueurById(int id)
        {
            return repo.GetById<Province>(id);
        }

        public IEnumerable<Province> ListeProvince()
        {
            return repo.GetAll<Province>();
        }

        public void UpdateJoueur(Province province)
        {
            repo.Update<Province>(province);
        }


    }
}
