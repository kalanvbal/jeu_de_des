namespace BalaramanpillaiKalan_TP3
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            textBoxJ1 = new TextBox();
            textBoxJ2 = new TextBox();
            label2 = new Label();
            buttonQuitter = new Button();
            buttonDébuter = new Button();
            textBoxRecord = new TextBox();
            label3 = new Label();
            richTextBoxRegle = new RichTextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Britannic Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(84, 52);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(575, 91);
            textBox1.TabIndex = 0;
            textBox1.Text = "Bienvenue à Beat That!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 328);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 2;
            // 
            // textBoxJ1
            // 
            textBoxJ1.Location = new Point(84, 363);
            textBoxJ1.Margin = new Padding(4, 5, 4, 5);
            textBoxJ1.Name = "textBoxJ1";
            textBoxJ1.Size = new Size(254, 31);
            textBoxJ1.TabIndex = 4;
            textBoxJ1.TextChanged += textBoxJ1_TextChanged;
            // 
            // textBoxJ2
            // 
            textBoxJ2.Location = new Point(406, 363);
            textBoxJ2.Margin = new Padding(4, 5, 4, 5);
            textBoxJ2.Name = "textBoxJ2";
            textBoxJ2.Size = new Size(253, 31);
            textBoxJ2.TabIndex = 7;
            textBoxJ2.TextChanged += textBoxJ2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 418);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 8;
            label2.Text = "Record:";
            // 
            // buttonQuitter
            // 
            buttonQuitter.Location = new Point(46, 701);
            buttonQuitter.Margin = new Padding(4, 5, 4, 5);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(204, 78);
            buttonQuitter.TabIndex = 9;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonDébuter
            // 
            buttonDébuter.Location = new Point(511, 701);
            buttonDébuter.Margin = new Padding(4, 5, 4, 5);
            buttonDébuter.Name = "buttonDébuter";
            buttonDébuter.Size = new Size(204, 78);
            buttonDébuter.TabIndex = 10;
            buttonDébuter.Text = "Débuter";
            buttonDébuter.UseVisualStyleBackColor = true;
            buttonDébuter.Click += buttonDébuter_Click;
            // 
            // textBoxRecord
            // 
            textBoxRecord.Location = new Point(184, 421);
            textBoxRecord.Margin = new Padding(4, 5, 4, 5);
            textBoxRecord.Multiline = true;
            textBoxRecord.Name = "textBoxRecord";
            textBoxRecord.ReadOnly = true;
            textBoxRecord.Size = new Size(475, 239);
            textBoxRecord.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(267, 317);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 32);
            label3.TabIndex = 12;
            label3.Text = "Nom des joueurs";
            // 
            // richTextBoxRegle
            // 
            richTextBoxRegle.Location = new Point(84, 155);
            richTextBoxRegle.Margin = new Padding(4, 5, 4, 5);
            richTextBoxRegle.Name = "richTextBoxRegle";
            richTextBoxRegle.ReadOnly = true;
            richTextBoxRegle.Size = new Size(575, 157);
            richTextBoxRegle.TabIndex = 13;
            richTextBoxRegle.Text = "";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 789);
            Controls.Add(richTextBoxRegle);
            Controls.Add(label3);
            Controls.Add(textBoxRecord);
            Controls.Add(buttonDébuter);
            Controls.Add(buttonQuitter);
            Controls.Add(label2);
            Controls.Add(textBoxJ2);
            Controls.Add(textBoxJ1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMenu";
            Text = "Beat That!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button buttonQuitter;
        private Button buttonDébuter;
        private TextBox textBoxRecord;
        private Label label3;
        private RichTextBox richTextBoxRegle;
        public TextBox textBoxJ1;
        public TextBox textBoxJ2;
    }
}