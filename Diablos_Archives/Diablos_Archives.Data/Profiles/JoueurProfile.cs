using AutoMapper;
using Diablos_Archives.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablos_Archives.Data
{
    public class JoueurProfile : Profile
    {
        public JoueurProfile()
        {
            CreateMap<Joueur, JoueurViewModel>();
            CreateMap<JoueurViewModel, Joueur>();
        }
    }
}
