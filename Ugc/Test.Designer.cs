namespace Ugc
{
    partial class Test
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.tlpTest = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAfficheColumnsWidth = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiffre_affaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modereglement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            this.tlpTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgClients
            // 
            this.dgClients.AllowUserToOrderColumns = true;
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.code,
            this.raison,
            this.fixe,
            this.mobile,
            this.email,
            this.Fax,
            this.famille,
            this.Solde,
            this.chiffre_affaire,
            this.ville,
            this.modereglement,
            this.type});
            this.dgClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgClients.Location = new System.Drawing.Point(3, 72);
            this.dgClients.Name = "dgClients";
            this.dgClients.Size = new System.Drawing.Size(794, 375);
            this.dgClients.TabIndex = 0;
            // 
            // tlpTest
            // 
            this.tlpTest.ColumnCount = 1;
            this.tlpTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTest.Controls.Add(this.dgClients, 0, 1);
            this.tlpTest.Controls.Add(this.BtnAfficheColumnsWidth, 0, 0);
            this.tlpTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTest.Location = new System.Drawing.Point(0, 0);
            this.tlpTest.Name = "tlpTest";
            this.tlpTest.RowCount = 2;
            this.tlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.46392F));
            this.tlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.53608F));
            this.tlpTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTest.Size = new System.Drawing.Size(800, 450);
            this.tlpTest.TabIndex = 1;
            // 
            // BtnAfficheColumnsWidth
            // 
            this.BtnAfficheColumnsWidth.Location = new System.Drawing.Point(3, 3);
            this.BtnAfficheColumnsWidth.Name = "BtnAfficheColumnsWidth";
            this.BtnAfficheColumnsWidth.Size = new System.Drawing.Size(181, 23);
            this.BtnAfficheColumnsWidth.TabIndex = 1;
            this.BtnAfficheColumnsWidth.Text = "Affiche Columns Width";
            this.BtnAfficheColumnsWidth.UseVisualStyleBackColor = true;
            this.BtnAfficheColumnsWidth.Click += new System.EventHandler(this.BtnAfficheColumnsWidth_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 30;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 35;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "Code";
            this.code.MaxInputLength = 10;
            this.code.Name = "code";
            this.code.Width = 71;
            // 
            // raison
            // 
            this.raison.DataPropertyName = "raison";
            this.raison.HeaderText = "Raison Sociale";
            this.raison.MaxInputLength = 250;
            this.raison.Name = "raison";
            this.raison.ToolTipText = "Nom ou Raison Sociale";
            this.raison.Width = 160;
            // 
            // fixe
            // 
            this.fixe.DataPropertyName = "fixe";
            this.fixe.HeaderText = "Fixe";
            this.fixe.MinimumWidth = 50;
            this.fixe.Name = "fixe";
            this.fixe.Width = 84;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "Mobile";
            this.mobile.MaxInputLength = 20;
            this.mobile.MinimumWidth = 30;
            this.mobile.Name = "mobile";
            this.mobile.Width = 84;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MaxInputLength = 50;
            this.email.MinimumWidth = 50;
            this.email.Name = "email";
            this.email.ToolTipText = "l\'Email ";
            this.email.Width = 147;
            // 
            // Fax
            // 
            this.Fax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Fax.DataPropertyName = "fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.MaxInputLength = 20;
            this.Fax.MinimumWidth = 30;
            this.Fax.Name = "Fax";
            this.Fax.ToolTipText = "N° de Fax";
            this.Fax.Width = 84;
            // 
            // famille
            // 
            this.famille.DataPropertyName = "famille";
            this.famille.HeaderText = "Famille";
            this.famille.MaxInputLength = 30;
            this.famille.Name = "famille";
            this.famille.ToolTipText = "La Famille Client";
            this.famille.Width = 70;
            // 
            // Solde
            // 
            this.Solde.DataPropertyName = "solde";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.Solde.DefaultCellStyle = dataGridViewCellStyle1;
            this.Solde.HeaderText = "Solde";
            this.Solde.MaxInputLength = 20;
            this.Solde.Name = "Solde";
            this.Solde.ToolTipText = "le Solde Client";
            this.Solde.Width = 84;
            // 
            // chiffre_affaire
            // 
            this.chiffre_affaire.DataPropertyName = "chiffre_affaire";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.chiffre_affaire.DefaultCellStyle = dataGridViewCellStyle2;
            this.chiffre_affaire.HeaderText = "C.A.";
            this.chiffre_affaire.MaxInputLength = 20;
            this.chiffre_affaire.Name = "chiffre_affaire";
            this.chiffre_affaire.ToolTipText = "Chiffer d\'Affaires";
            this.chiffre_affaire.Width = 84;
            // 
            // ville
            // 
            this.ville.DataPropertyName = "ville";
            this.ville.HeaderText = "Ville";
            this.ville.MaxInputLength = 30;
            this.ville.Name = "ville";
            this.ville.ToolTipText = "Ville Client";
            // 
            // modereglement
            // 
            this.modereglement.DataPropertyName = "modereglement";
            this.modereglement.HeaderText = "Mode.Reg.";
            this.modereglement.MaxInputLength = 30;
            this.modereglement.Name = "modereglement";
            this.modereglement.ToolTipText = "Mode de Réglement";
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.MaxInputLength = 20;
            this.type.Name = "type";
            this.type.ToolTipText = "Type Tiers";
            this.type.Width = 70;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpTest);
            this.Name = "Test";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            this.tlpTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClients;
        private System.Windows.Forms.TableLayoutPanel tlpTest;
        private System.Windows.Forms.Button BtnAfficheColumnsWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn raison;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixe;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn famille;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solde;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiffre_affaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn modereglement;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}