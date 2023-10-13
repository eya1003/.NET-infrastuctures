using SW.Models;
using System.Net;

namespace SW.Services
{
    public class DivisionPatriote
    {
        public List<Patriote> Patriotes { get; set; }
        public List<Distinction> Distinctions { get; set; } = new List<Distinction>();

        public List<Sanction> Sanctions { get; set; } = new List<Sanction>();



        public DivisionPatriote()
        {
            Patriotes = new List<Patriote>();
        }

        public void AddPatriote(Distinction distinction )
        {
            if (distinction != null && distinction.DecerneA is Patriote)
            {
                var patrioteCible = (Patriote)distinction.DecerneA;

                // Recherchez le Patriote cible dans la liste des Patriotes
                var patriote = Patriotes.FirstOrDefault(p => p.Id == patrioteCible.Id);

                if (patriote != null)
                {
                    // Ajoutez la distinction à la liste des distinctions du Patriote cible
                   Distinctions.Add(distinction);
                }
                else
                {
                    //  le Patriote cible n'a pas été trouvé 
                }
            }
            else
            {
                //  la distinction n'est pas décernée à un Patriote
            }

        }

        public Nouveau GetPatriote(int id)
        {
            return null;
        }

        public void AddSanction(Sanction sanction)
        {
            if (sanction != null && sanction.InfligeA is Patriote)
            {
                var patrioteCible = (Patriote)sanction.InfligeA;

                // Recherchez le Patriote cible dans la liste des Patriotes
                var patriote = Patriotes.FirstOrDefault(p => p.Id == patrioteCible.Id);

                if (patriote != null)
                {
                    // Ajoutez la sanction à la liste des sanctions du Patriote cible
                    Sanctions.Add(sanction);
                }
                else
                {
                    //  Patriote n'a pas été trouvé 
                    Console.WriteLine("périote introuvable dans liste patriotes");
                }
            }
            else
            {
                //  sanction n'a pas un Patriote 
                Console.WriteLine("sanction n'a pas patriote");


            }

        }
        


    }
}