using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVenteApp.Mes_Classe
{
    internal class Achat
    {
        private int codeClient; //{ get; set; }

        private int codeArticle; //{ get; set; }

        private DateTime date; //{ get; set; }

        private decimal montant; //{ get; set; }

        // la methode du professeur
        public int CodeClient { get => codeClient; set => codeClient = value; }
        public int CodeArticle { get => codeArticle; set => codeArticle = value; }
        public DateTime Date { get => date; set => date = value; }
        public decimal Montant { get => montant; set => montant = value; }

        // Constructeur
        public Achat(int codeClient, int codeArticle, DateTime date, decimal montant)
        {
            CodeClient = codeClient;
            CodeArticle = codeArticle;
            Date = date;
            Montant = montant;
        }

        // Méthode
        public void Ajouter(List<Achat> achats)
        {
            achats.Add(this);
            Console.WriteLine("Achat reussie avec succès.");
        }
    }
}
