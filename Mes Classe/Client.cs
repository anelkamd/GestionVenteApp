using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVenteApp.Mes_Classe
{
    internal class Client
    {
        public int Code { get; set; }
        public string Nom { get; set; }
        public string PostNom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }

        // Constructeur
        public Client(int code, string nom, string postNom, string prenom, string sexe, string telephone, string adresse)
        {
            Code = code;
            Nom = nom;
            PostNom = postNom;
            Prenom = prenom;
            Sexe = sexe;
            Telephone = telephone;
            Adresse = adresse;
        }

        // Méthodes
        public void Enregistre(List<Client> clients)
        {
            clients.Add(this);
            Console.WriteLine("Client enregistré avec succès.");
        }

        public void Modifier(string nom, string postNom, string prenom, string sexe, string telephone, string adresse)
        {
            Nom = nom;
            PostNom = postNom;
            Prenom = prenom;
            Sexe = sexe;
            Telephone = telephone;
            Adresse = adresse;
            Console.WriteLine("Client modifié avec succès.");
        }

        public void Supprimer(List<Client> clients)
        {
            clients.Remove(this);
            Console.WriteLine("Client supprimé avec succès.");
        }
    }
}
