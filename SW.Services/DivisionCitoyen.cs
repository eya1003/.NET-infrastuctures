using SW.DataAcessLayer;
using SW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW.Services
{
    public class DivisionCitoyen
    {
        public CitoyenRepository citoyenRepository { get; set; }
        public DivisionCitoyen (CitoyenRepository repositroy)
        {
            citoyenRepository = repositroy;

        }
        public void AddCitoyen(Citoyen c)
        {
            //regles de gestion
            //age des parents, présence des parents, espèce,etc
            citoyenRepository.AddCitoyen(c);
        }

        public List<Citoyen> GetCitoyens()
        {
            return citoyenRepository.GetCitoyens();
        }
           
    }
}
