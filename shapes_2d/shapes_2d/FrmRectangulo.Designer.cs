namespace shapes_2d
{
    partial class FrmRectangulo
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
            this.LblEntrada = new System.Windows.Forms.Label();
            this.LblAncho = new System.Windows.Forms.Label();
            this.LblLargo = new System.Windows.Forms.Label();
            this.TxtAncho = new System.Windows.Forms.TextBox();
            this.TxtLargo = new System.Windows.Forms.TextBox();
            this.LblGrafico = new System.Windows.Forms.Label();
            this.LblProceso = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnResetear = new System.Windows.Forms.Button();
            this.LblSalida = new System.Windows.Forms.Label();
            this.LblPerimetro = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblEntrada
            // 
            this.LblEntrada.AutoSize = true;
            this.LblEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.LblEntrada.Location = new System.Drawing.Point(40, 66);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(57, 16);
            this.LblEntrada.TabIndex = 0;
            this.LblEntrada.Text = "Entrada:";
            // 
            // LblAncho
            // 
            this.LblAncho.AutoSize = true;
            this.LblAncho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LblAncho.Location = new System.Drawing.Point(40, 98);
            this.LblAncho.Name = "LblAncho";
            this.LblAncho.Size = new System.Drawing.Size(67, 16);
            this.LblAncho.TabIndex = 1;
            this.LblAncho.Text = "Ancho (a):";
            // 
            // LblLargo
            // 
            this.LblLargo.AutoSize = true;
            this.LblLargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LblLargo.Location = new System.Drawing.Point(40, 141);
            this.LblLargo.Name = "LblLargo";
            this.LblLargo.Size = new System.Drawing.Size(64, 16);
            this.LblLargo.TabIndex = 2;
            this.LblLargo.Text = "Largo (b):";
            // 
            // TxtAncho
            // 
            this.TxtAncho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtAncho.Location = new System.Drawing.Point(140, 99);
            this.TxtAncho.Name = "TxtAncho";
            this.TxtAncho.Size = new System.Drawing.Size(140, 30);
            this.TxtAncho.TabIndex = 3;
            // 
            // TxtLargo
            // 
            this.TxtLargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtLargo.Location = new System.Drawing.Point(140, 138);
            this.TxtLargo.Name = "TxtLargo";
            this.TxtLargo.Size = new System.Drawing.Size(140, 30);
            this.TxtLargo.TabIndex = 4;
            // 
            // LblGrafico
            // 
            this.LblGrafico.AutoSize = true;
            this.LblGrafico.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.LblGrafico.Location = new System.Drawing.Point(620, 66);
            this.LblGrafico.Name = "LblGrafico";
            this.LblGrafico.Size = new System.Drawing.Size(53, 16);
            this.LblGrafico.TabIndex = 5;
            this.LblGrafico.Text = "Gráfico:";
            // 
            // LblProceso
            // 
            this.LblProceso.AutoSize = true;
            this.LblProceso.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.LblProceso.Location = new System.Drawing.Point(40, 224);
            this.LblProceso.Name = "LblProceso";
            this.LblProceso.Size = new System.Drawing.Size(61, 16);
            this.LblProceso.TabIndex = 6;
            this.LblProceso.Text = "Proceso:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCalcular.ForeColor = System.Drawing.Color.White;
            this.BtnCalcular.Location = new System.Drawing.Point(40, 261);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(110, 32);
            this.BtnCalcular.TabIndex = 7;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(300, 261);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 32);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnResetear
            // 
            this.BtnResetear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BtnResetear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnResetear.Location = new System.Drawing.Point(170, 261);
            this.BtnResetear.Name = "BtnResetear";
            this.BtnResetear.Size = new System.Drawing.Size(110, 32);
            this.BtnResetear.TabIndex = 9;
            this.BtnResetear.Text = "Resetear";
            this.BtnResetear.UseVisualStyleBackColor = true;
            this.BtnResetear.Click += new System.EventHandler(this.BtnResetear_Click);
            // 
            // LblSalida
            // 
            this.LblSalida.AutoSize = true;
            this.LblSalida.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.LblSalida.Location = new System.Drawing.Point(40, 324);
            this.LblSalida.Name = "LblSalida";
            this.LblSalida.Size = new System.Drawing.Size(56, 16);
            this.LblSalida.TabIndex = 10;
            this.LblSalida.Text = "Salidas:";
            // 
            // LblPerimetro
            // 
            this.LblPerimetro.AutoSize = true;
            this.LblPerimetro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LblPerimetro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.LblPerimetro.Location = new System.Drawing.Point(40, 358);
            this.LblPerimetro.Name = "LblPerimetro";
            this.LblPerimetro.Size = new System.Drawing.Size(68, 16);
            this.LblPerimetro.TabIndex = 11;
            this.LblPerimetro.Text = "Perimetro:";
            this.LblPerimetro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.LblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.LblArea.Location = new System.Drawing.Point(40, 398);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(39, 16);
            this.LblArea.TabIndex = 12;
            this.LblArea.Text = "Área:";
            // 
            // FrmRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1007, 586);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.LblPerimetro);
            this.Controls.Add(this.LblSalida);
            this.Controls.Add(this.BtnResetear);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblProceso);
            this.Controls.Add(this.LblGrafico);
            this.Controls.Add(this.TxtLargo);
            this.Controls.Add(this.TxtAncho);
            this.Controls.Add(this.LblLargo);
            this.Controls.Add(this.LblAncho);
            this.Controls.Add(this.LblEntrada);
            this.Name = "FrmRectangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rectangulo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmRectangulo_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEntrada;
        private System.Windows.Forms.Label LblAncho;
        private System.Windows.Forms.Label LblLargo;
        private System.Windows.Forms.TextBox TxtAncho;
        private System.Windows.Forms.TextBox TxtLargo;
        private System.Windows.Forms.Label LblGrafico;
        private System.Windows.Forms.Label LblProceso;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnResetear;
        private System.Windows.Forms.Label LblSalida;
        private System.Windows.Forms.Label LblPerimetro;
        private System.Windows.Forms.Label LblArea;
    }
}