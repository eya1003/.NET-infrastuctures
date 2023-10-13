using SW.Models;

namespace SW.DataAcessLayer
{
    public class CitoyenRepository
    {
        public StarWarsDBContext SWDBContext { get; set; }
        public CitoyenRepository(StarWarsDBContext SWDBContext)
        {
            SWDBContext = SWDBContext;
        }
        public void AddCitoyen(Citoyen c)
        {
        

        }
        public List<Citoyen> GetCitoyens()
        {
            return SWDBContext.Citoyens.ToList();
        }
    }
}