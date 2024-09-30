using System.Numerics;
using System.Windows.Forms;

namespace BalaramanpillaiKalan_TP3
{
    public partial class FormMenu : Form
    {
        string chemin = Application.StartupPath + "\\";
        string regle = "regle.txt";
        string pointage = "pointage.txt";
        public FormMenu()
        {
            InitializeComponent();
            buttonDébuter.Enabled = false;
            load();
        }

        private void status()
        {
            if (textBoxJ1.Text != "" && textBoxJ2.Text != "")
            {
                buttonDébuter.Enabled = true;
            }
            else
            {
                buttonDébuter.Enabled = false;
            }
        }

        private void load()
        {


            var record = 0;
            var user = "";

            StreamReader reader = new StreamReader(chemin + pointage);

            do
            {
                string data = reader.ReadLine();
                var info = data.Split('>');
                int point = Int32.Parse(info[1]);

                if (point > record)
                {
                    record = point;
                    user = info[0];
                }

            } while (!reader.EndOfStream);

            reader.Close();

            Joueur joueur = new Joueur(user, Color.White, record);

            textBoxRecord.Text = joueur.ToString();


            var texte = "";

            StreamReader reader2 = new StreamReader(chemin + "regle.txt");

            do
            {
                texte += reader2.ReadLine() + "\r\n";

            } while (!reader2.EndOfStream);
            richTextBoxRegle.Text = texte;

            reader2.Close();


        }

        private void textBoxJ1_TextChanged(object sender, EventArgs e)
        {
            status();
        }

        private void textBoxJ2_TextChanged(object sender, EventArgs e)
        {
            status();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDébuter_Click(object sender, EventArgs e)
        {
            Jeu jeu = new Jeu(this);
            jeu.ShowDialog();
            textBoxJ1.Clear();
            textBoxJ2.Clear();
            load();
        }
    }
}