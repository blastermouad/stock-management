namespace LABRIME.mouad.PL
{
    partial class USER_Liste_Client
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textrecherche = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.comborecherche = new System.Windows.Forms.ComboBox();
            this.dvgclient = new System.Windows.Forms.DataGridView();
            this.btnsuprimerclient = new System.Windows.Forms.Button();
            this.btnmodifierclient = new System.Windows.Forms.Button();
            this.btnajouteclient = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.panel1.Location = new System.Drawing.Point(80, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 3);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.panel2.Location = new System.Drawing.Point(80, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 3);
            this.panel2.TabIndex = 4;
            // 
            // textrecherche
            // 
            this.textrecherche.BackColor = System.Drawing.SystemColors.Control;
            this.textrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textrecherche.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textrecherche.ForeColor = System.Drawing.Color.Silver;
            this.textrecherche.Location = new System.Drawing.Point(653, 110);
            this.textrecherche.Multiline = true;
            this.textrecherche.Name = "textrecherche";
            this.textrecherche.Size = new System.Drawing.Size(325, 41);
            this.textrecherche.TabIndex = 5;
            this.textrecherche.Text = "Recherche";
            this.textrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textrecherche.TextChanged += new System.EventHandler(this.textrecherche_TextChanged);
            this.textrecherche.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.panel3.Location = new System.Drawing.Point(653, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 3);
            this.panel3.TabIndex = 5;
            // 
            // comborecherche
            // 
            this.comborecherche.AutoCompleteCustomSource.AddRange(new string[] {
            "Nom",
            "Prenom",
            "Telephone",
            "Email",
            "Ville",
            "Pays"});
            this.comborecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comborecherche.FormattingEnabled = true;
            this.comborecherche.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Adresse",
            "Telephone",
            "Email",
            "Ville",
            "Pays"});
            this.comborecherche.Location = new System.Drawing.Point(291, 110);
            this.comborecherche.Name = "comborecherche";
            this.comborecherche.Size = new System.Drawing.Size(325, 44);
            this.comborecherche.TabIndex = 7;
            this.comborecherche.SelectedIndexChanged += new System.EventHandler(this.comborecherche_SelectedIndexChanged);
            // 
            // dvgclient
            // 
            this.dvgclient.AllowUserToAddRows = false;
            this.dvgclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgclient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgclient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dvgclient.EnableHeadersVisualStyles = false;
            this.dvgclient.Location = new System.Drawing.Point(0, 196);
            this.dvgclient.Name = "dvgclient";
            this.dvgclient.RowHeadersVisible = false;
            this.dvgclient.RowHeadersWidth = 51;
            this.dvgclient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgclient.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgclient.RowTemplate.Height = 24;
            this.dvgclient.Size = new System.Drawing.Size(1252, 657);
            this.dvgclient.TabIndex = 8;
            this.dvgclient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgclient_CellContentClick);
            // 
            // btnsuprimerclient
            // 
            this.btnsuprimerclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnsuprimerclient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuprimerclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsuprimerclient.Image = global::LABRIME.mouad.Properties.Resources.R__5_;
            this.btnsuprimerclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsuprimerclient.Location = new System.Drawing.Point(846, 11);
            this.btnsuprimerclient.Name = "btnsuprimerclient";
            this.btnsuprimerclient.Size = new System.Drawing.Size(325, 58);
            this.btnsuprimerclient.TabIndex = 2;
            this.btnsuprimerclient.Text = "Supprimer";
            this.btnsuprimerclient.UseVisualStyleBackColor = false;
            this.btnsuprimerclient.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnmodifierclient
            // 
            this.btnmodifierclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnmodifierclient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifierclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodifierclient.Image = global::LABRIME.mouad.Properties.Resources.ser_icon4;
            this.btnmodifierclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifierclient.Location = new System.Drawing.Point(462, 9);
            this.btnmodifierclient.Name = "btnmodifierclient";
            this.btnmodifierclient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnmodifierclient.Size = new System.Drawing.Size(325, 60);
            this.btnmodifierclient.TabIndex = 1;
            this.btnmodifierclient.Text = "Modifier";
            this.btnmodifierclient.UseVisualStyleBackColor = false;
            this.btnmodifierclient.Click += new System.EventHandler(this.btnmodifierclient_Click);
            // 
            // btnajouteclient
            // 
            this.btnajouteclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(43)))));
            this.btnajouteclient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouteclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnajouteclient.Image = global::LABRIME.mouad.Properties.Resources.plus_icon;
            this.btnajouteclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouteclient.Location = new System.Drawing.Point(80, 9);
            this.btnajouteclient.Name = "btnajouteclient";
            this.btnajouteclient.Size = new System.Drawing.Size(325, 60);
            this.btnajouteclient.TabIndex = 0;
            this.btnajouteclient.Text = "Ajouter";
            this.btnajouteclient.UseVisualStyleBackColor = false;
            this.btnajouteclient.Click += new System.EventHandler(this.btnajouteclient_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prenom";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adresse";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telephone";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ville";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Pays";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // USER_Liste_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dvgclient);
            this.Controls.Add(this.comborecherche);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textrecherche);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsuprimerclient);
            this.Controls.Add(this.btnmodifierclient);
            this.Controls.Add(this.btnajouteclient);
            this.Name = "USER_Liste_Client";
            this.Size = new System.Drawing.Size(1253, 853);
            this.Load += new System.EventHandler(this.USER_Liste_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnajouteclient;
        private System.Windows.Forms.Button btnmodifierclient;
        private System.Windows.Forms.Button btnsuprimerclient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textrecherche;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comborecherche;
        private System.Windows.Forms.DataGridView dvgclient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
