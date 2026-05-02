namespace shapes_2d
{
    partial class FrmCruz
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
            this.LblArea = new System.Windows.Forms.Label();
            this.LblPerimetro = new System.Windows.Forms.Label();
            this.LblSalida = new System.Windows.Forms.Label();
            this.BtnResetear = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblProceso = new System.Windows.Forms.Label();
            this.LblGrafico = new System.Windows.Forms.Label();
            this.TxtTamaño = new System.Windows.Forms.TextBox();
            this.LblTamaño = new System.Windows.Forms.Label();
            this.LblEntrada = new System.Windows.Forms.Label();
            this.pnlCruz = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.LblArea.Location = new System.Drawing.Point(60, 374);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(49, 23);
            this.LblArea.TabIndex = 25;
            this.LblArea.Text = "Área:";
            // 
            // LblPerimetro
            // 
            this.LblPerimetro.AutoSize = true;
            this.LblPerimetro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LblPerimetro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.LblPerimetro.Location = new System.Drawing.Point(60, 334);
            this.LblPerimetro.Name = "LblPerimetro";
            this.LblPerimetro.Size = new System.Drawing.Size(88, 23);
            this.LblPerimetro.TabIndex = 24;
            this.LblPerimetro.Text = "Perimetro:";
            this.LblPerimetro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblSalida
            // 
            this.LblSalida.AutoSize = true;
            this.LblSalida.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.LblSalida.Location = new System.Drawing.Point(60, 300);
            this.LblSalida.Name = "LblSalida";
            this.LblSalida.Size = new System.Drawing.Size(76, 25);
            this.LblSalida.TabIndex = 23;
            this.LblSalida.Text = "Salidas:";
            // 
            // BtnResetear
            // 
            this.BtnResetear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BtnResetear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnResetear.Location = new System.Drawing.Point(190, 246);
            this.BtnResetear.Name = "BtnResetear";
            this.BtnResetear.Size = new System.Drawing.Size(110, 32);
            this.BtnResetear.TabIndex = 22;
            this.BtnResetear.Text = "Resetear";
            this.BtnResetear.UseVisualStyleBackColor = true;
            this.BtnResetear.Click += new System.EventHandler(this.BtnResetear_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(320, 246);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 32);
            this.BtnSalir.TabIndex = 21;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCalcular.ForeColor = System.Drawing.Color.White;
            this.BtnCalcular.Location = new System.Drawing.Point(60, 246);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(110, 32);
            this.BtnCalcular.TabIndex = 20;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // LblProceso
            // 
            this.LblProceso.AutoSize = true;
            this.LblProceso.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.LblProceso.Location = new System.Drawing.Point(60, 209);
            this.LblProceso.Name = "LblProceso";
            this.LblProceso.Size = new System.Drawing.Size(84, 25);
            this.LblProceso.TabIndex = 19;
            this.LblProceso.Text = "Proceso:";
            // 
            // LblGrafico
            // 
            this.LblGrafico.AutoSize = true;
            this.LblGrafico.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.LblGrafico.Location = new System.Drawing.Point(640, 51);
            this.LblGrafico.Name = "LblGrafico";
            this.LblGrafico.Size = new System.Drawing.Size(79, 25);
            this.LblGrafico.TabIndex = 18;
            this.LblGrafico.Text = "Gráfico:";
            // 
            // TxtTamaño
            // 
            this.TxtTamaño.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtTamaño.Location = new System.Drawing.Point(190, 103);
            this.TxtTamaño.Name = "TxtTamaño";
            this.TxtTamaño.Size = new System.Drawing.Size(140, 30);
            this.TxtTamaño.TabIndex = 16;
            // 
            // LblTamaño
            // 
            this.LblTamaño.AutoSize = true;
            this.LblTamaño.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LblTamaño.Location = new System.Drawing.Point(62, 110);
            this.LblTamaño.Name = "LblTamaño";
            this.LblTamaño.Size = new System.Drawing.Size(74, 23);
            this.LblTamaño.TabIndex = 14;
            this.LblTamaño.Text = "Tamaño:";
            // 
            // LblEntrada
            // 
            this.LblEntrada.AutoSize = true;
            this.LblEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.LblEntrada.Location = new System.Drawing.Point(60, 51);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(83, 25);
            this.LblEntrada.TabIndex = 13;
            this.LblEntrada.Text = "Entrada:";
            // 
            // pnlCruz
            // 
            this.pnlCruz.Location = new System.Drawing.Point(645, 96);
            this.pnlCruz.Name = "pnlCruz";
            this.pnlCruz.Size = new System.Drawing.Size(529, 384);
            this.pnlCruz.TabIndex = 27;
            this.pnlCruz.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCruz_Paint);
            // 
            // FrmCruz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlCruz);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.LblPerimetro);
            this.Controls.Add(this.LblSalida);
            this.Controls.Add(this.BtnResetear);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblProceso);
            this.Controls.Add(this.LblGrafico);
            this.Controls.Add(this.TxtTamaño);
            this.Controls.Add(this.LblTamaño);
            this.Controls.Add(this.LblEntrada);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCruz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cruz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.Label LblPerimetro;
        private System.Windows.Forms.Label LblSalida;
        private System.Windows.Forms.Button BtnResetear;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label LblProceso;
        private System.Windows.Forms.Label LblGrafico;
        private System.Windows.Forms.TextBox TxtTamaño;
        private System.Windows.Forms.Label LblTamaño;
        private System.Windows.Forms.Label LblEntrada;
        private System.Windows.Forms.Panel pnlCruz;
    }
}
