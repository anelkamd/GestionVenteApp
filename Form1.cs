using GestionVenteApp.Mes_Classe;
using Microsoft.Data.SqlClient;

namespace GestionVenteApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmClient frm = new frmClient();
            frm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmArticle frm = new frmArticle();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAchat frm = new FrmAchat();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAcces data = new DataAcces();
            bool isOpen = data.OpenConnection();
            if (isOpen)
            {
                MessageBox.Show("Connexion reussie");
            }
            else
            {
                MessageBox.Show("Connexion a echoue...");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmApropot frm = new FrmApropot();
            frm.Show();
        }
    }
}
