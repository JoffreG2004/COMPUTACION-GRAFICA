namespace shapes_2d
{
    partial class FrmParalelogramo
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
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.BtnResetear = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.lblProceso = new System.Windows.Forms.Label();
            this.lblGrafico = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtInclinacion = new System.Windows.Forms.TextBox();
            this.lblLargo = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblInclinacion = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.lblArea.Location = new System.Drawing.Point(79, 382);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(40, 19);
            this.lblArea.TabIndex = 25;
            this.lblArea.Text = "Área:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPerimetro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.lblPerimetro.Location = new System.Drawing.Point(79, 342);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(73, 19);
            this.lblPerimetro.TabIndex = 24;
            this.lblPerimetro.Text = "Perimetro:";
            this.lblPerimetro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalida.Location = new System.Drawing.Point(79, 308);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(60, 20);
            this.lblSalida.TabIndex = 23;
            this.lblSalida.Text = "Salidas:";
            // 
            // BtnResetear
            // 
            this.BtnResetear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BtnResetear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnResetear.Location = new System.Drawing.Point(209, 245);
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
            this.BtnSalir.Location = new System.Drawing.Point(339, 245);
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
            this.BtnCalcular.Location = new System.Drawing.Point(79, 245);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(110, 32);
            this.BtnCalcular.TabIndex = 20;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblProceso.Location = new System.Drawing.Point(79, 208);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(67, 20);
            this.lblProceso.TabIndex = 19;
            this.lblProceso.Text = "Proceso:";
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblGrafico.Location = new System.Drawing.Point(659, 50);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(62, 20);
            this.lblGrafico.TabIndex = 18;
            this.lblGrafico.Text = "Gráfico:";
            // 
            // txtLargo
            // 
            this.txtLargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLargo.Location = new System.Drawing.Point(179, 122);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(140, 25);
            this.txtLargo.TabIndex = 17;
            // 
            // txtAncho
            // 
            this.txtAncho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAncho.Location = new System.Drawing.Point(179, 83);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(140, 25);
            this.txtAncho.TabIndex = 16;
            // 
            // txtInclinacion
            // 
            this.txtInclinacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInclinacion.Location = new System.Drawing.Point(179, 162);
            this.txtInclinacion.Name = "txtInclinacion";
            this.txtInclinacion.Size = new System.Drawing.Size(140, 25);
            this.txtInclinacion.TabIndex = 18;
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLargo.Location = new System.Drawing.Point(79, 125);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(67, 19);
            this.lblLargo.TabIndex = 15;
            this.lblLargo.Text = "Altura (b):";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAncho.Location = new System.Drawing.Point(79, 82);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(70, 19);
            this.lblAncho.TabIndex = 14;
            this.lblAncho.Text = "Ancho (a):";
            // 
            // lblInclinacion
            // 
            this.lblInclinacion.AutoSize = true;
            this.lblInclinacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInclinacion.Location = new System.Drawing.Point(79, 165);
            this.lblInclinacion.Name = "lblInclinacion";
            this.lblInclinacion.Size = new System.Drawing.Size(87, 19);
            this.lblInclinacion.TabIndex = 18;
            this.lblInclinacion.Text = "Inclinación:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblEntrada.Location = new System.Drawing.Point(79, 50);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(66, 20);
            this.lblEntrada.TabIndex = 13;
            this.lblEntrada.Text = "Entrada:";
            // 
            // FrmParalelogramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.BtnResetear);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.lblGrafico);
            this.Controls.Add(this.txtInclinacion);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblInclinacion);
            this.Controls.Add(this.lblEntrada);
            this.Name = "FrmParalelogramo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paralelogramo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmParalelogramo_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Button BtnResetear;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.Label lblGrafico;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtInclinacion;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblInclinacion;
        private System.Windows.Forms.Label lblEntrada;
    }
}