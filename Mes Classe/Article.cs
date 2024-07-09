using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace GestionVenteApp.Mes_Classe
{
    internal class Article
    {
        public int Code { get; set; }
        public string Designation { get; set; }
        public int PU { get; set; }
        public int QT { get; set; }

        

        // Constructeur
        public Article(int code, string designation, int pu, int qt)
        {
            Code = code;
            Designation = designation;
            PU = pu;
            QT = qt;
        }
        DataAcces data = new DataAcces();
        // Méthodes
        public int Ajouter(Article article)
        {

            int resultat = 0;
            String strQuery = "insert into Article(codeArticle,designation,PU,QT" + "value(@codeArticle, @designation, @PU, @QT)";
                if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery,data.conn);
                cmd.Parameters.AddWithValue("@code", article.Code);
                cmd.Parameters.AddWithValue("@designation", article.Designation);
                cmd.Parameters.AddWithValue("@PU", article.PU);
                cmd.Parameters.AddWithValue("@QT", article.QT);
                cmd.Parameters.AddWithValue("@Code", article.Code);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }
        public List<Article>GetArticles()
        {
            List<Article> list = new List<Article>();
            String StrQuery = "select * from Article";
            if (data.OpenConnection()) 
            { 
                SqlCommand cmd = new SqlCommand(StrQuery,data.conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Article art = new Article();
                    art.Code = Convert.ToInt32(rd[Code]);
                    art.Designation = Convert.ToString( rd[Designation]);
                    art.PU = Convert.ToInt32(rd["PU"]);
                    art.QT = Convert.ToInt32(rd[QT]);
                    list.Add(art);
                    
                }
                rd.Close();
                cmd.Dispose();
                data.CloseConnection();
            }
            return list;
        }

        public int Modifier(Article article)
        {
            int resultat = 0;
            String strQuery = "update Article set codeArticle=@codeArticle,designation=@designation,PU=@PU,QT=@QT";
            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.conn);
                cmd.Parameters.AddWithValue("@code", article.Code);
                cmd.Parameters.AddWithValue("@designation", article.Designation);
                cmd.Parameters.AddWithValue("@PU", article.PU);
                cmd.Parameters.AddWithValue("@QT", article.QT);
                cmd.Parameters.AddWithValue("@Code", article.Code);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }

        public int Supprimer(Article article)
        {
            int resultat = 0;
            String strQuery = "delete Article where codeArticle=@codeArticle";
            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.conn);
                cmd.Parameters.AddWithValue("@code", article.Code);
                cmd.Parameters.AddWithValue("@designation", article.Designation);
                cmd.Parameters.AddWithValue("@PU", article.PU);
                cmd.Parameters.AddWithValue("@QT", article.QT);
                cmd.Parameters.AddWithValue("@Code", article.Code);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                data.CloseConnection();
            }
            return resultat;
        }
    }
}
