namespace Ugc
{
    partial class Clients
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
            this.TlpClients = new System.Windows.Forms.TableLayoutPanel();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.TlpClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpClients
            // 
            this.TlpClients.ColumnCount = 2;
            this.TlpClients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.29834F));
            this.TlpClients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.701657F));
            this.TlpClients.Controls.Add(this.txtQuery, 0, 0);
            this.TlpClients.Controls.Add(this.btnGo, 1, 0);
            this.TlpClients.Controls.Add(this.txtResult, 0, 1);
            this.TlpClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpClients.Location = new System.Drawing.Point(0, 0);
            this.TlpClients.Name = "TlpClients";
            this.TlpClients.RowCount = 2;
            this.TlpClients.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.70186F));
            this.TlpClients.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.29813F));
            this.TlpClients.Size = new System.Drawing.Size(800, 450);
            this.TlpClients.TabIndex = 0;
            // 
            // txtQuery
            // 
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuery.Location = new System.Drawing.Point(3, 3);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(724, 73);
            this.txtQuery.TabIndex = 0;
            this.txtQuery.Text = "call clients_all()";
            // 
            // btnGo
            // 
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGo.Location = new System.Drawing.Point(733, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(64, 73);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtResult
            // 
            this.TlpClients.SetColumnSpan(this.txtResult, 2);
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 82);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(794, 365);
            this.txtResult.TabIndex = 2;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TlpClients);
            this.ForeColor = System.Drawing.Color.SandyBrown;
            this.Name = "Clients";
            this.Text = "Clients";
            this.TlpClients.ResumeLayout(false);
            this.TlpClients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpClients;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtResult;
    }
}