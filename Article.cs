using GestionVenteApp.Mes_Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;

namespace GestionVenteApp
{
    public partial class frmArticle : Form
    {
        public frmArticle()
        {
            InitializeComponent();
        }
        Article article = new Article();
        private void bindingClass()
        {
            article.Designation = txDesignation.Text;
            article.PU = Convert.ToDouble(tPU.Text);
            article.QT = Convert.ToInt32(tQT.Text);
            article.Code = Convert.ToInt32(tCode.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bindingClass();
                int resultat = article.Ajouter(article);
                if (resultat > 0)
                {
                    MessageBox.Show("Ajout Reussie");
                }
                else
                {
                    MessageBox.Show("L'ajout a echoue");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un Probleme s'est produit veillez ressaiyer !!!");
            }
        }

        private void frmArticle_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgArticles.DataSource = article.GetArticles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de Chargement Article");
            }
        }
    }
}
