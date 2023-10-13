using SW.Models;

namespace SW.Services
{
    public class DivisionNouveau
    {
        public List<Nouveau> Nouveaux { get; set; }
        public List<Distinction> Distinctions { get; set; } = new List<Distinction>();

        public List<Sanction> Sanctions { get; set; } = new List<Sanction>();


        public DivisionNouveau()
        {
            Nouveaux = new List<Nouveau>();
        }

        public void AddNouveau(Nouveau nouveau)
        {
            Nouveaux.Add(nouveau);
        }

        public Nouveau GetNouveau(int id)
        {
            //par findId
            return null;
        }

        public void RemoveNouveau(int id)
        {

        }

        public void AddDistinction(Distinction distinction)
        {
            if (distinction != null)
            {
                //  la Distinction est décernée à un Nouveau
                if (distinction.DecerneA != null)
                {
                    // Recherchez le Nouveau dans la liste des Nouveaux
                    var nouveau = Nouveaux.FirstOrDefault(n => n.Id == distinction.DecerneA.Id);

                    if (nouveau != null)
                    {
                        // Ajout de la Distinction à ce Nouveau

                        Distinctions.Add(distinction);

                    }
                    else
                    {
                        //  Nouveau introuvable
                    }
                }
                else
                {
                    // Gla Distinction n'est pas décernée à un Nouveau 
                    
                }
            }
        }

        public void AddSanction(Sanction sanction)
        {
            if (sanction != null)
            {
                //  la Distinction est décernée à un Nouveau
                if (sanction.InfligeA != null)
                {
                    // Recherchez le Nouveau dans la liste des Nouveaux
                    var nouveau = Nouveaux.FirstOrDefault(n => n.Id == sanction.InfligeA.Id);

                    if (nouveau != null)
                    {
                        // Ajout de la Distinction à ce Nouveau
                        Sanctions.Add(sanction);

                    }
                    else
                    {
                        //  Nouveau introuvable
                    }
                }
                else
                {
                    // Gla Distinction n'est pas décernée à un Nouveau 

                }
            }
        }
    }
}