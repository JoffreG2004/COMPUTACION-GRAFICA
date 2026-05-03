using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmLunaCreciente : Form
    {
        private double tamaño;

        public FrmLunaCreciente()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtTamaño.Text, out tamaño) || tamaño <= 0)
            {
                MessageBox.Show("Tamaño (a) debe ser un número válido mayor a 0");
                return;
            }

            double radio = tamaño * 10d;
            double radioInterno = radio * 0.6d;
            double area = Math.PI * (radio * radio - radioInterno * radioInterno);
            double perimetro = (2 * Math.PI * radio) + (2 * Math.PI * radioInterno);

            lblPerimetro.Text = $"Perímetro: {perimetro:F2}";
            lblArea.Text = $"Área: {area:F2}";

            this.Invalidate();
        }

        private void BtnResetear_Click(object sender, EventArgs e)
        {
            txtTamaño.Text = "";
            lblPerimetro.Text = "Perimetro:";
            lblArea.Text = "Área:";
            tamaño = 0;
            this.Invalidate();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLunaCreciente_Paint(object sender, PaintEventArgs e)
        {
            if (tamaño <= 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Ajustamos la escala para que se vea bien en pantalla
            float radioExterior = (float)tamaño * 10f;
            float radioInterior = radioExterior * 0.9f; // Un poco más grande para una luna delgada

            float x = 700f;
            float y = 150f;

            // Definimos el camino de la figura
            using (GraphicsPath lunaPath = new GraphicsPath())
            {
                // 1. Agregamos el círculo exterior (la base)
                lunaPath.AddEllipse(x, y, radioExterior * 2, radioExterior * 2);

             
                float desplazamientoX = radioExterior * 0.5f;
                float desplazamientoY = 0f;

                GraphicsPath circuloRecorte = new GraphicsPath();
                circuloRecorte.AddEllipse(x + desplazamientoX, y + desplazamientoY, radioInterior * 2, radioInterior * 2);

              
                Region regionLuna = new Region(lunaPath);
                regionLuna.Exclude(circuloRecorte); 

                using (Brush brushLuna = new SolidBrush(Color.FromArgb(184, 199, 112)))
                {
                    g.FillRegion(brushLuna, regionLuna);
                }

                g.Clip = regionLuna;
                using (Pen penBorde = new Pen(Color.FromArgb(45, 52, 71), 3))
                {
                    
                    g.DrawEllipse(penBorde, x, y, radioExterior * 2, radioExterior * 2);
                    g.DrawEllipse(penBorde, x + desplazamientoX, y + desplazamientoY, radioInterior * 2, radioInterior * 2);
                }

                g.ResetClip();
            }
        }
    }
}
