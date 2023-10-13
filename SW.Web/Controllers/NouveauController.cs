using Microsoft.AspNetCore.Mvc;
using SW.Models;
using SW.Services;

namespace SW.Web.Controllers
{
    public class NouveauController : Controller
    {
        public DivisionNouveau Division { get; set; }

        public DivisionCitoyen DivisionCitoyen { get; set; }
        public NouveauController(DivisionCitoyen DivisionCitoyen)
        {
            Division = new DivisionNouveau();
            DivisionCitoyen =  DivisionCitoyen;


        }
        public IActionResult Index()
        {
            this.ViewData["Nom"] = "AMOR";
            //index doit retourner une liste de nouveaux 
            // on ne veut pas ça ViewData["Nouveau"] = Division.Nouveaux;

            // return View(Division.Nouveaux); ça marche correctement

            /*var noms = new List<string>
            {
                "AMOR",
                "Ben AMOR"
            };
            return View(noms);
            */
            return View(Division.Nouveaux);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Nouveau nouveau)
        {
            try
            {
                Division.AddNouveau(nouveau);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
