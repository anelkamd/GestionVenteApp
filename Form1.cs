using GestionVenteApp.Mes_Classe;

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
            Client frm = new Client();
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
            Article frm = new Article();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Achat frm = new Achat();
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
            Apropot frm = new Apropot();
            frm.Show();
        }
    }
}
