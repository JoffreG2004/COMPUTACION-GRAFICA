namespace shapes_2d
{
    partial class FrmElipse
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
            this.txtRadio2 = new System.Windows.Forms.TextBox();
            this.txtRadio1 = new System.Windows.Forms.TextBox();
            this.lblRadio2 = new System.Windows.Forms.Label();
            this.lblRadio1 = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.lblArea.Location = new System.Drawing.Point(79, 392);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(40, 19);
            this.lblArea.TabIndex = 24;
            this.lblArea.Text = "Área:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPerimetro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(150)))));
            this.lblPerimetro.Location = new System.Drawing.Point(79, 362);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(73, 19);
            this.lblPerimetro.TabIndex = 23;
            this.lblPerimetro.Text = "Perimetro:";
            this.lblPerimetro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblSalida.Location = new System.Drawing.Point(79, 328);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(60, 20);
            this.lblSalida.TabIndex = 22;
            this.lblSalida.Text = "Salidas:";
            // 
            // BtnResetear
            // 
            this.BtnResetear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BtnResetear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResetear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnResetear.Location = new System.Drawing.Point(209, 265);
            this.BtnResetear.Name = "BtnResetear";
            this.BtnResetear.Size = new System.Drawing.Size(110, 32);
            this.BtnResetear.TabIndex = 21;
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
            this.BtnSalir.Location = new System.Drawing.Point(339, 265);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 32);
            this.BtnSalir.TabIndex = 20;
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
            this.BtnCalcular.Location = new System.Drawing.Point(79, 265);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(110, 32);
            this.BtnCalcular.TabIndex = 19;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblProceso.Location = new System.Drawing.Point(79, 228);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(67, 20);
            this.lblProceso.TabIndex = 18;
            this.lblProceso.Text = "Proceso:";
            // 
            // lblGrafico
            // 
            this.lblGrafico.AutoSize = true;
            this.lblGrafico.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblGrafico.Location = new System.Drawing.Point(659, 70);
            this.lblGrafico.Name = "lblGrafico";
            this.lblGrafico.Size = new System.Drawing.Size(62, 20);
            this.lblGrafico.TabIndex = 17;
            this.lblGrafico.Text = "Gráfico:";
            // 
            // txtRadio2
            // 
            this.txtRadio2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRadio2.Location = new System.Drawing.Point(179, 142);
            this.txtRadio2.Name = "txtRadio2";
            this.txtRadio2.Size = new System.Drawing.Size(140, 25);
            this.txtRadio2.TabIndex = 16;
            // 
            // txtRadio1
            // 
            this.txtRadio1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRadio1.Location = new System.Drawing.Point(179, 103);
            this.txtRadio1.Name = "txtRadio1";
            this.txtRadio1.Size = new System.Drawing.Size(140, 25);
            this.txtRadio1.TabIndex = 15;
            // 
            // lblRadio2
            // 
            this.lblRadio2.AutoSize = true;
            this.lblRadio2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRadio2.Location = new System.Drawing.Point(79, 145);
            this.lblRadio2.Name = "lblRadio2";
            this.lblRadio2.Size = new System.Drawing.Size(66, 19);
            this.lblRadio2.TabIndex = 14;
            this.lblRadio2.Text = "Radio (b):";
            // 
            // lblRadio1
            // 
            this.lblRadio1.AutoSize = true;
            this.lblRadio1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRadio1.Location = new System.Drawing.Point(79, 102);
            this.lblRadio1.Name = "lblRadio1";
            this.lblRadio1.Size = new System.Drawing.Size(65, 19);
            this.lblRadio1.TabIndex = 13;
            this.lblRadio1.Text = "Radio (a):";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblEntrada.Location = new System.Drawing.Point(79, 70);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(66, 20);
            this.lblEntrada.TabIndex = 12;
            this.lblEntrada.Text = "Entrada:";
            // 
            // FrmElipse
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
            this.Controls.Add(this.txtRadio2);
            this.Controls.Add(this.txtRadio1);
            this.Controls.Add(this.lblRadio2);
            this.Controls.Add(this.lblRadio1);
            this.Controls.Add(this.lblEntrada);
            this.Name = "FrmElipse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elipse";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmElipse_Paint);
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
        private System.Windows.Forms.TextBox txtRadio2;
        private System.Windows.Forms.TextBox txtRadio1;
        private System.Windows.Forms.Label lblRadio2;
        private System.Windows.Forms.Label lblRadio1;
        private System.Windows.Forms.Label lblEntrada;
    }
}