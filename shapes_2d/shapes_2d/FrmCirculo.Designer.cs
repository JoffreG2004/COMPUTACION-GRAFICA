namespace shapes_2d
{
    partial class FrmCirculo
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
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lblLargo = new System.Windows.Forms.Label();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.lblArea.Location = new System.Drawing.Point(152, 351);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(40, 19);
            this.lblArea.TabIndex = 37;
            this.lblArea.Text = "Área:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPerimetro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.lblPerimetro.Location = new System.Drawing.Point(152, 318);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(73, 19);
            this.lblPerimetro.TabIndex = 36;
            this.lblPerimetro.Text = "Perimetro:";
            this.lblPerimetro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalida.Location = new System.Drawing.Point(152, 291);
            this.lblSalida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(60, 20);
            this.lblSalida.TabIndex = 35;
            this.lblSalida.Text = "Salidas:";
            // 
            // BtnResetear
            // 
            this.BtnResetear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BtnResetear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnResetear.Location = new System.Drawing.Point(250, 239);
            this.BtnResetear.Margin = new System.Windows.Forms.Padding(2);
            this.BtnResetear.Name = "BtnResetear";
            this.BtnResetear.Size = new System.Drawing.Size(82, 26);
            this.BtnResetear.TabIndex = 34;
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
            this.BtnSalir.Location = new System.Drawing.Point(347, 239);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(82, 26);
            this.BtnSalir.TabIndex = 33;
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
            this.BtnCalcular.Location = new System.Drawing.Point(152, 239);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(82, 26);
            this.BtnCalcular.TabIndex = 32;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblProceso.Location = new System.Drawing.Point(152, 209);
            this.lblProceso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(67, 20);
            this.lblProceso.TabIndex = 31;
            this.lblProceso.Text = "Proceso:";
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblGrafico.Location = new System.Drawing.Point(587, 81);
            this.lblGrafico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(62, 20);
            this.lblGrafico.TabIndex = 30;
            this.lblGrafico.Text = "Gráfico:";
            // 
            // txtRadio
            // 
            this.txtRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRadio.Location = new System.Drawing.Point(227, 108);
            this.txtRadio.Margin = new System.Windows.Forms.Padding(2);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(106, 25);
            this.txtRadio.TabIndex = 29;
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLargo.Location = new System.Drawing.Point(152, 142);
            this.lblLargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(0, 19);
            this.lblLargo.TabIndex = 28;
            this.lblLargo.Visible = false;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRadio.Location = new System.Drawing.Point(152, 107);
            this.lblRadio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(65, 19);
            this.lblRadio.TabIndex = 27;
            this.lblRadio.Text = "Radio (a):";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblEntrada.Location = new System.Drawing.Point(152, 81);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(66, 20);
            this.lblEntrada.TabIndex = 26;
            this.lblEntrada.Text = "Entrada:";
            // 
            // FrmCirculo
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
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.lblEntrada);
            this.Name = "FrmCirculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circulo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmCirculo_Paint);
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
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblEntrada;
    }
}