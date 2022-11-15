namespace GeneradorKardex2022
{
    partial class FormatoKardexSUNAT
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
            this.rpvFormatoKardexSUNAT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvFormatoKardexSUNAT
            // 
            this.rpvFormatoKardexSUNAT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvFormatoKardexSUNAT.Location = new System.Drawing.Point(0, 0);
            this.rpvFormatoKardexSUNAT.Name = "rpvFormatoKardexSUNAT";
            this.rpvFormatoKardexSUNAT.ServerReport.BearerToken = null;
            this.rpvFormatoKardexSUNAT.Size = new System.Drawing.Size(800, 450);
            this.rpvFormatoKardexSUNAT.TabIndex = 0;
            // 
            // FormatoKardexSUNAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvFormatoKardexSUNAT);
            this.Name = "FormatoKardexSUNAT";
            this.Text = "FormatoKardexSUNAT";
            this.Load += new System.EventHandler(this.FormatoKardexSUNAT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvFormatoKardexSUNAT;
    }
}