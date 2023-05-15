namespace LABRIME.mouad.PL
{
    partial class FRM_Connexion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textmoddepasse = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnquitter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(526, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 583);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 2);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 581);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(2, 581);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(524, 2);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(160, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Connexion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNom
            // 
            this.textNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.textNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textNom.Location = new System.Drawing.Point(94, 207);
            this.textNom.Multiline = true;
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(385, 42);
            this.textNom.TabIndex = 5;
            this.textNom.Text = "Nom d\'utilisateur";
            this.textNom.Enter += new System.EventHandler(this.txtNom_Enter);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Location = new System.Drawing.Point(94, 255);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 1);
            this.panel4.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Yellow;
            this.panel6.Location = new System.Drawing.Point(94, 386);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 1);
            this.panel6.TabIndex = 8;
            // 
            // textmoddepasse
            // 
            this.textmoddepasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.textmoddepasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.textmoddepasse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textmoddepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textmoddepasse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textmoddepasse.Location = new System.Drawing.Point(94, 338);
            this.textmoddepasse.Multiline = true;
            this.textmoddepasse.Name = "textmoddepasse";
            this.textmoddepasse.Size = new System.Drawing.Size(385, 42);
            this.textmoddepasse.TabIndex = 7;
            this.textmoddepasse.Text = "Mot de passe";
            this.textmoddepasse.Enter += new System.EventHandler(this.txtmotdepasse_Enter);
            this.textmoddepasse.Leave += new System.EventHandler(this.txtmotdepasse_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LABRIME.mouad.Properties.Resources._29774;
            this.pictureBox2.Location = new System.Drawing.Point(26, 338);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 42);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LABRIME.mouad.Properties.Resources._47964;
            this.pictureBox1.Location = new System.Drawing.Point(26, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 49);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnquitter
            // 
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.Image = global::LABRIME.mouad.Properties.Resources.R4;
            this.btnquitter.Location = new System.Drawing.Point(435, 3);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(85, 93);
            this.btnquitter.TabIndex = 3;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(32, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(471, 65);
            this.button1.TabIndex = 11;
            this.button1.Text = "Se Connecter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(528, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textmoddepasse);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ". ";
            this.Load += new System.EventHandler(this.FRM_Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textmoddepasse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}