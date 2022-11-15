namespace GeneradorKardex2022
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnKardexSUNAT = new GeneradorKardex.RJButton();
            this.btnKardexPI = new GeneradorKardex.RJButton();
            this.btnKardexPT = new GeneradorKardex.RJButton();
            this.btnKardexMP = new GeneradorKardex.RJButton();
            this.btnImportarDatos = new GeneradorKardex.RJButton();
            this.btnReporteCostoUnico = new GeneradorKardex.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generador de Kardex y Reportes";
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgvDatos.Location = new System.Drawing.Point(12, 76);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(1248, 497);
            this.dgvDatos.TabIndex = 1;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // btnKardexSUNAT
            // 
            this.btnKardexSUNAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKardexSUNAT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKardexSUNAT.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKardexSUNAT.BorderRadius = 9;
            this.btnKardexSUNAT.BorderSize = 0;
            this.btnKardexSUNAT.FlatAppearance.BorderSize = 0;
            this.btnKardexSUNAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKardexSUNAT.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKardexSUNAT.ForeColor = System.Drawing.Color.White;
            this.btnKardexSUNAT.Location = new System.Drawing.Point(797, 594);
            this.btnKardexSUNAT.Name = "btnKardexSUNAT";
            this.btnKardexSUNAT.Size = new System.Drawing.Size(161, 55);
            this.btnKardexSUNAT.TabIndex = 2;
            this.btnKardexSUNAT.Text = "Kardex SUNAT";
            this.btnKardexSUNAT.TextColor = System.Drawing.Color.White;
            this.btnKardexSUNAT.UseVisualStyleBackColor = false;
            // 
            // btnKardexPI
            // 
            this.btnKardexPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKardexPI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKardexPI.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKardexPI.BorderRadius = 9;
            this.btnKardexPI.BorderSize = 0;
            this.btnKardexPI.FlatAppearance.BorderSize = 0;
            this.btnKardexPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKardexPI.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKardexPI.ForeColor = System.Drawing.Color.White;
            this.btnKardexPI.Location = new System.Drawing.Point(319, 594);
            this.btnKardexPI.Name = "btnKardexPI";
            this.btnKardexPI.Size = new System.Drawing.Size(161, 55);
            this.btnKardexPI.TabIndex = 3;
            this.btnKardexPI.Text = "Kardex PI";
            this.btnKardexPI.TextColor = System.Drawing.Color.White;
            this.btnKardexPI.UseVisualStyleBackColor = false;
            // 
            // btnKardexPT
            // 
            this.btnKardexPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKardexPT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKardexPT.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKardexPT.BorderRadius = 9;
            this.btnKardexPT.BorderSize = 0;
            this.btnKardexPT.FlatAppearance.BorderSize = 0;
            this.btnKardexPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKardexPT.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKardexPT.ForeColor = System.Drawing.Color.White;
            this.btnKardexPT.Location = new System.Drawing.Point(553, 594);
            this.btnKardexPT.Name = "btnKardexPT";
            this.btnKardexPT.Size = new System.Drawing.Size(161, 55);
            this.btnKardexPT.TabIndex = 4;
            this.btnKardexPT.Text = "Kardex PT";
            this.btnKardexPT.TextColor = System.Drawing.Color.White;
            this.btnKardexPT.UseVisualStyleBackColor = false;
            // 
            // btnKardexMP
            // 
            this.btnKardexMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKardexMP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnKardexMP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKardexMP.BorderRadius = 9;
            this.btnKardexMP.BorderSize = 0;
            this.btnKardexMP.FlatAppearance.BorderSize = 0;
            this.btnKardexMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKardexMP.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKardexMP.ForeColor = System.Drawing.Color.White;
            this.btnKardexMP.Location = new System.Drawing.Point(73, 594);
            this.btnKardexMP.Name = "btnKardexMP";
            this.btnKardexMP.Size = new System.Drawing.Size(161, 55);
            this.btnKardexMP.TabIndex = 5;
            this.btnKardexMP.Text = "Kardex MP";
            this.btnKardexMP.TextColor = System.Drawing.Color.White;
            this.btnKardexMP.UseVisualStyleBackColor = false;
            // 
            // btnImportarDatos
            // 
            this.btnImportarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(1)))));
            this.btnImportarDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(1)))));
            this.btnImportarDatos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnImportarDatos.BorderRadius = 9;
            this.btnImportarDatos.BorderSize = 0;
            this.btnImportarDatos.FlatAppearance.BorderSize = 0;
            this.btnImportarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarDatos.ForeColor = System.Drawing.Color.White;
            this.btnImportarDatos.Location = new System.Drawing.Point(1148, 39);
            this.btnImportarDatos.Name = "btnImportarDatos";
            this.btnImportarDatos.Size = new System.Drawing.Size(112, 31);
            this.btnImportarDatos.TabIndex = 6;
            this.btnImportarDatos.Text = "Importar datos";
            this.btnImportarDatos.TextColor = System.Drawing.Color.White;
            this.btnImportarDatos.UseVisualStyleBackColor = false;
            this.btnImportarDatos.Click += new System.EventHandler(this.btnImportarDatos_Click);
            // 
            // btnReporteCostoUnico
            // 
            this.btnReporteCostoUnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReporteCostoUnico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReporteCostoUnico.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReporteCostoUnico.BorderRadius = 9;
            this.btnReporteCostoUnico.BorderSize = 0;
            this.btnReporteCostoUnico.FlatAppearance.BorderSize = 0;
            this.btnReporteCostoUnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCostoUnico.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCostoUnico.ForeColor = System.Drawing.Color.White;
            this.btnReporteCostoUnico.Location = new System.Drawing.Point(1029, 594);
            this.btnReporteCostoUnico.Name = "btnReporteCostoUnico";
            this.btnReporteCostoUnico.Size = new System.Drawing.Size(161, 55);
            this.btnReporteCostoUnico.TabIndex = 7;
            this.btnReporteCostoUnico.Text = "Reporte Costo Unico";
            this.btnReporteCostoUnico.TextColor = System.Drawing.Color.White;
            this.btnReporteCostoUnico.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 661);
            this.Controls.Add(this.btnReporteCostoUnico);
            this.Controls.Add(this.btnImportarDatos);
            this.Controls.Add(this.btnKardexMP);
            this.Controls.Add(this.btnKardexPT);
            this.Controls.Add(this.btnKardexPI);
            this.Controls.Add(this.btnKardexSUNAT);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1290, 700);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private GeneradorKardex.RJButton btnKardexSUNAT;
        private GeneradorKardex.RJButton btnKardexPI;
        private GeneradorKardex.RJButton btnKardexPT;
        private GeneradorKardex.RJButton btnKardexMP;
        private GeneradorKardex.RJButton btnImportarDatos;
        private GeneradorKardex.RJButton btnReporteCostoUnico;
    }
}

