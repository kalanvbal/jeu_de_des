using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalaramanpillaiKalan_TP3
{
    public partial class Modifier : Form
    {
        Jeu jeu;

        Color[] couleurs = { Color.Brown, Color.Blue, Color.Pink, Color.Purple, Color.Red };
        string[] couleursLettre = { "Brun", "Bleu", "Rose", "Mauve", "Rouge" };
        public Modifier(Jeu jeu)
        {
            InitializeComponent();
            this.jeu = jeu;
            buttonSauvegarder.Enabled = false;
            completer();
        }
        private void completer()
        {
            comboBoxCouleur.Items.AddRange(couleursLettre);
            comboBoxNom.Items.Add(jeu.textBoxNom1.Text);
            comboBoxNom.Items.Add(jeu.textBoxNom2.Text);
        }

        private void activation()
        {
            if (comboBoxNom.SelectedIndex != -1 && textBoxNewNom.Text != ""
                && comboBoxCouleur.SelectedIndex != -1)
            {
                buttonSauvegarder.Enabled = true;
            }
            else
            {
                buttonSauvegarder.Enabled = false;
            }
        }
        private void buttonSauvegarder_Click(object sender, EventArgs e)
        {
            var indexNom = comboBoxNom.SelectedIndex;
            var indexColor = comboBoxCouleur.SelectedIndex;


            TextBox tb = (TextBox)jeu.Controls.Find("textBoxNom" + (indexNom + 1), true).FirstOrDefault();

            if (tb != null)
            {
                tb.Text = textBoxNewNom.Text;
                tb.BackColor = couleurs[indexColor];
                this.Close();
            }
            else
            {

                MessageBox.Show("TextBox pas trouve.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void comboBoxNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            activation();
        }

        private void textBoxNewNom_TextChanged(object sender, EventArgs e)
        {
            activation();
        }

        private void comboBoxCouleur_SelectedIndexChanged(object sender, EventArgs e)
        {
            activation();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
