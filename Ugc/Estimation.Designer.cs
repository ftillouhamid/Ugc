namespace Ugc
{
    partial class Estimation
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
            this.TlpEstimation = new System.Windows.Forms.TableLayoutPanel();
            this.BtnGo = new System.Windows.Forms.Button();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.WbEstimation = new System.Windows.Forms.WebBrowser();
            this.TlpEstimation.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlpEstimation
            // 
            this.TlpEstimation.ColumnCount = 2;
            this.TlpEstimation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.63636F));
            this.TlpEstimation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.36364F));
            this.TlpEstimation.Controls.Add(this.BtnGo, 1, 0);
            this.TlpEstimation.Controls.Add(this.TxtUrl, 0, 0);
            this.TlpEstimation.Controls.Add(this.WbEstimation, 0, 1);
            this.TlpEstimation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpEstimation.Location = new System.Drawing.Point(0, 0);
            this.TlpEstimation.Name = "TlpEstimation";
            this.TlpEstimation.RowCount = 2;
            this.TlpEstimation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.868502F));
            this.TlpEstimation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.1315F));
            this.TlpEstimation.Size = new System.Drawing.Size(800, 450);
            this.TlpEstimation.TabIndex = 0;
            // 
            // BtnGo
            // 
            this.BtnGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnGo.Location = new System.Drawing.Point(712, 3);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(85, 33);
            this.BtnGo.TabIndex = 0;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            // 
            // TxtUrl
            // 
            this.TxtUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUrl.Location = new System.Drawing.Point(3, 3);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(703, 20);
            this.TxtUrl.TabIndex = 1;
            // 
            // WbEstimation
            // 
            this.TlpEstimation.SetColumnSpan(this.WbEstimation, 2);
            this.WbEstimation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WbEstimation.Location = new System.Drawing.Point(3, 42);
            this.WbEstimation.MinimumSize = new System.Drawing.Size(20, 20);
            this.WbEstimation.Name = "WbEstimation";
            this.WbEstimation.ScriptErrorsSuppressed = true;
            this.WbEstimation.Size = new System.Drawing.Size(794, 405);
            this.WbEstimation.TabIndex = 2;
            this.WbEstimation.Url = new System.Uri("http://192.168.1.8/estimation.html", System.UriKind.Absolute);
            // 
            // Estimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TlpEstimation);
            this.Name = "Estimation";
            this.Text = "Estimation";
            this.Load += new System.EventHandler(this.Estimation_Load);
            this.TlpEstimation.ResumeLayout(false);
            this.TlpEstimation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpEstimation;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.WebBrowser WbEstimation;
    }
}