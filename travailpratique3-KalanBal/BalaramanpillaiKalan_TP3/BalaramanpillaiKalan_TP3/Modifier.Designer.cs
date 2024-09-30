namespace BalaramanpillaiKalan_TP3
{
    partial class Modifier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxNom = new ComboBox();
            comboBoxCouleur = new ComboBox();
            textBoxNewNom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonQuitter = new Button();
            buttonSauvegarder = new Button();
            SuspendLayout();
            // 
            // comboBoxNom
            // 
            comboBoxNom.FormattingEnabled = true;
            comboBoxNom.Location = new Point(111, 71);
            comboBoxNom.Name = "comboBoxNom";
            comboBoxNom.Size = new Size(182, 33);
            comboBoxNom.TabIndex = 0;
            comboBoxNom.SelectedIndexChanged += comboBoxNom_SelectedIndexChanged;
            // 
            // comboBoxCouleur
            // 
            comboBoxCouleur.FormattingEnabled = true;
            comboBoxCouleur.Location = new Point(111, 249);
            comboBoxCouleur.Name = "comboBoxCouleur";
            comboBoxCouleur.Size = new Size(182, 33);
            comboBoxCouleur.TabIndex = 1;
            comboBoxCouleur.SelectedIndexChanged += comboBoxCouleur_SelectedIndexChanged;
            // 
            // textBoxNewNom
            // 
            textBoxNewNom.Location = new Point(111, 164);
            textBoxNewNom.Name = "textBoxNewNom";
            textBoxNewNom.Size = new Size(182, 31);
            textBoxNewNom.TabIndex = 2;
            textBoxNewNom.TextChanged += textBoxNewNom_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 221);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 3;
            label1.Text = "Couleur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 29);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 4;
            label2.Text = "Nom ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 124);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 5;
            label3.Text = "Nouveau nom";
            // 
            // buttonQuitter
            // 
            buttonQuitter.Location = new Point(255, 321);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(112, 34);
            buttonQuitter.TabIndex = 6;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonSauvegarder
            // 
            buttonSauvegarder.Location = new Point(32, 321);
            buttonSauvegarder.Name = "buttonSauvegarder";
            buttonSauvegarder.Size = new Size(126, 34);
            buttonSauvegarder.TabIndex = 7;
            buttonSauvegarder.Text = "Sauvegarder";
            buttonSauvegarder.UseVisualStyleBackColor = true;
            buttonSauvegarder.Click += buttonSauvegarder_Click;
            // 
            // Modifier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 450);
            Controls.Add(buttonSauvegarder);
            Controls.Add(buttonQuitter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNewNom);
            Controls.Add(comboBoxCouleur);
            Controls.Add(comboBoxNom);
            Name = "Modifier";
            Text = "Modifier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxNom;
        private ComboBox comboBoxCouleur;
        private TextBox textBoxNewNom;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonQuitter;
        private Button buttonSauvegarder;
    }
}