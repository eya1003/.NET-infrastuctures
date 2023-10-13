using SW.Models;
using SW.Services;

namespace SW.Tests
{
    public class DivisionTests
    {
        public void TestAddDistinctionFonctionnaireANouveau()
        {
            var e = new Espece
            {
                Nom = "especeNom",
                Longevite = 1,
                Majorite = 2
            };
            var nouveau = new Nouveau
            {
                Id = 1,
                Nom = "bEN aMOR",
                Prenom = "Nour",
                Age = 22,
                Espece = e
            };

            var fonctionnaire = new Fonctionnaire
            {
                Id = 2,
                Nom= "eya",
                Prenom = "amor",
                Age= 18,
                Espece = e
            };
            var distinction = new Distinction
            {
                BonusMerite = 10,
                Date = DateTime.Now,
                DecernePar = fonctionnaire,
                DecerneA = nouveau
            };
            var divisionNouveau = new DivisionNouveau();
            
            divisionNouveau.AddDistinction(distinction);
        }

        [Fact]
        public void TestAddSanctionFonctionnaireANouveau() {
            var e = new Espece
            {
                Nom = "especeNom",
                Longevite = 1,
                Majorite = 2
            };
            var nouveau = new Nouveau
            {
                Id = 2,
                Nom = "bEN ",
                Prenom = "awat",
                Age = 22,
                Espece = e
            };

            var fonctionnaire = new Fonctionnaire
            {
                Id = 3,
                Nom = "ayo",
                Prenom = "aorm",
                Age = 21,
                Espece = e
            };
            var sanction = new Sanction
            {
                InfligeA = fonctionnaire,
                InfligePar = nouveau,
                MalusMerite = 20
            };
            var divisionNouveau = new DivisionNouveau();

            divisionNouveau.AddSanction(sanction);
        }

        [Fact]
        public void TestAddDistinctionPatrioteAPatriote() {
            var patriote1 = new Patriote
            {
                Id = 1,
                Age = 28,
                Nom = "zaghdoud",
                Prenom = "Habib"
            };
            var patriote2 = new Patriote
            {
                Id = 2,
                Age = 28,
                Nom = "ben",
                Prenom = "amel"
            };
            var distinction = new Distinction
            {
                BonusMerite = 14,
                Date = DateTime.Now,
                DecernePar = patriote1,
                DecerneA = patriote2
            };
            var divisionPatriote = new DivisionPatriote();

            divisionPatriote.AddPatriote(distinction);
        }

        [Fact]
        public void TestAddSanctionFonctionnaireAPatriote() {

            Patriote patriote = new Patriote
            {
                Id = 3,
                Nom = "nom",
                Age = 19
            };

            // Créez une sanction
            Sanction sanction = new Sanction
            {
                Date = DateTime.Now,
                InfligeA = patriote,
            };
            var divisionPatriote = new DivisionPatriote();
            divisionPatriote.AddSanction(sanction);


        }

        [Fact]
        public void TestAddDistinctionParPereOuMere() {

           
        }

        [Fact]
        public void TestAddDistinctionParAscendant() { 

        }

        [Fact]
        public void TestAddSanctionParCitoyenMemeCaste() { 

        }

        [Fact]
        public void TestAddDistinctionParCitoyenCasteInferieure() { 

        }

        [Fact]
        public void TestAddDistinctionSousSanctionMoinsDe6Mois() { 

        }
    }
}