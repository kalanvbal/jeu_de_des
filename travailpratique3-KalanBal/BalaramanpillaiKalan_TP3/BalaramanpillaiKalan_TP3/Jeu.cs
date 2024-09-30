using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalaramanpillaiKalan_TP3
{
    public partial class Jeu : Form
    {
        Partie partie;
        const int nbJoueur = 2;
        Joueur[] tabJoueur = new Joueur[2];
        Thread[] tabDe = new Thread[4];
        Thread de1, de2, de3, de4;

        int[,] tabIndex = new int[2, 2];
        string chemin = Application.StartupPath + "\\";
        FormMenu menu;
        int nbPartie = 0;


        public Jeu(FormMenu formMenu)
        {
            InitializeComponent();
            buttonArreter.Enabled = false;
            this.menu = formMenu;
            tabDe[0] = de1;
            tabDe[1] = de2;
            tabDe[2] = de3;
            tabDe[3] = de4;

            tabJoueur[0] = new Joueur(menu.textBoxJ1.Text, Color.Blue, 0);
            tabJoueur[1] = new Joueur(menu.textBoxJ2.Text, Color.Pink, 0);

            textBoxNom1.Text = tabJoueur[0]._name;
            textBoxNom2.Text = tabJoueur[1]._name;
            textBoxNom1.BackColor = tabJoueur[0]._couleur;
            textBoxNom2.BackColor = tabJoueur[1]._couleur;
        }

        private void buttonBrasser_Click(object sender, EventArgs e)
        {
            buttonBrasser.Enabled = false;
            buttonArreter.Enabled = true;
            Random random = new Random();

            tabDe[0] = new Thread(t =>
            {

                try
                {

                    while (tabDe[0].IsAlive)
                    {
                        int indexIMG = random.Next(1, 6);
                        pictureBoxD1.ImageLocation = chemin + indexIMG + ".png";
                        tabIndex[0, 0] = indexIMG;
                        Thread.Sleep(30);
                    }

                }
                catch (Exception ex) { }
            })
            { IsBackground = true };

            tabDe[1] = new Thread(t =>
            {

                try
                {

                    while (tabDe[1].IsAlive)
                    {
                        int indexIMG = random.Next(1, 6);
                        pictureBoxD2.ImageLocation = chemin + indexIMG + ".png";
                        tabIndex[0, 1] = indexIMG;
                        Thread.Sleep(30);
                    }

                }
                catch (Exception ex) { }
            })
            { IsBackground = true };

            tabDe[2] = new Thread(t =>
            {

                try
                {

                    while (tabDe[2].IsAlive)
                    {
                        int indexIMG = random.Next(1, 6);
                        pictureBoxD3.ImageLocation = chemin + indexIMG + ".png";
                        tabIndex[1, 0] = indexIMG;
                        Thread.Sleep(30);
                    }

                }
                catch (Exception ex) { }
            })
            { IsBackground = true };

            tabDe[3] = new Thread(t =>
            {

                try
                {

                    while (tabDe[3].IsAlive)
                    {
                        int indexIMG = random.Next(1, 6);
                        pictureBoxD4.ImageLocation = chemin + indexIMG + ".png";
                        tabIndex[1, 1] = indexIMG;
                        Thread.Sleep(30);
                    }

                }
                catch (Exception ex) { }
            })
            { IsBackground = true };

            tabDe[0].Start();
            tabDe[1].Start();
            tabDe[2].Start();
            tabDe[3].Start();
        }

        private void buttonArreter_Click(object sender, EventArgs e)
        {
            SoundPlayer lecteur = new SoundPlayer();
            lecteur.SoundLocation = Application.StartupPath + "stop-13692.wav";
            lecteur.Play();

            tabDe[0].Interrupt();
            tabDe[1].Interrupt();
            tabDe[2].Interrupt();
            tabDe[3].Interrupt();

            buttonArreter.Enabled = false;
            buttonBrasser.Enabled = true;

            int somme1 = tabIndex[0, 0] + tabIndex[0, 1];
            int somme2 = tabIndex[1, 0] + tabIndex[1, 1];
            if (somme1 == somme2)
            {
                richTextBoxGagnant.Text = "=";
            }
            else if (somme1 > somme2)
            {
                tabJoueur[0]._pointage++;

                richTextBoxGagnant.Text = ">";
            }
            else
            {
                tabJoueur[1]._pointage++;

                richTextBoxGagnant.Text = "<";
            }
            textBoxSomme1.Text = somme1.ToString();
            textBoxRonde1.Text = tabJoueur[0]._pointage.ToString();
            textBoxSomme2.Text = somme2.ToString();
            textBoxRonde2.Text = tabJoueur[1]._pointage.ToString();
        }

        private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabJoueur[0]._pointage = 0;
            tabJoueur[1]._pointage = 0;
            textBoxSomme1.Text = 0.ToString();
            textBoxSomme2.Text = 0.ToString();
            textBoxRonde1.Text = 0.ToString();
            textBoxRonde2.Text = 0.ToString();
            richTextBoxGagnant.Clear();
        }

        private void sauvegardePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fichier = chemin + "pointage.txt";


            File.AppendAllText(fichier, tabJoueur[0].ToString() + Environment.NewLine);
            File.AppendAllText(fichier, tabJoueur[1].ToString() + Environment.NewLine);

            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifierJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier modifier = new Modifier(this);
            modifier.ShowDialog();
            tabJoueur[0]._name = textBoxNom1.Text;
            tabJoueur[1]._name = textBoxNom2.Text;
            tabJoueur[0]._couleur = textBoxNom1.BackColor;
            tabJoueur[1]._couleur = textBoxNom2.BackColor;
        }
    }

}




