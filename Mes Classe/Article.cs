using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVenteApp.Mes_Classe
{
    internal class Article
    {
        public int Code { get; set; }
        public string Designation { get; set; }
        public decimal PU { get; set; }
        public int QT { get; set; }

        // Constructeur
        public Article(int code, string designation, decimal pu, int qt)
        {
            Code = code;
            Designation = designation;
            PU = pu;
            QT = qt;
        }

        // Méthodes
        public void Ajouter(List<Article> articles)
        {
            articles.Add(this);
            Console.WriteLine("Article ajouté avec succès.");
        }

        public void Modifier(string designation, decimal pu, int qt)
        {
            Designation = designation;
            PU = pu;
            QT = qt;
            Console.WriteLine("Article modifié avec succès.");
        }

        public void Supprimer(List<Article> articles)
        {
            articles.Remove(this);
            Console.WriteLine("Article supprimé avec succès.");
        }
    }
}
