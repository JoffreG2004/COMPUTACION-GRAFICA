using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmRombo : Form
    {
        private double ancho;

        public FrmRombo()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(TxtAncho.Text, out ancho) || ancho <= 0)
            {
                MessageBox.Show("Ancho (a) debe ser un número válido mayor a 0");
                return;
            }

            double perimetro = 4 * ancho;
            double area = ancho * ancho;

            LblPerimetro.Text = $"Perímetro: {perimetro:F2}";
            LblArea.Text = $"Área: {area:F2}";

            this.Invalidate();
        }

        private void BtnResetear_Click(object sender, EventArgs e)
        {
            TxtAncho.Text = "";
            LblPerimetro.Text = "Perimetro:";
            LblArea.Text = "Área:";
            ancho = 0;
            this.Invalidate();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRombo_Paint(object sender, PaintEventArgs e)
        {
            if (ancho <= 0)
            {
                return;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Black, 2))
            using (Brush fill = new SolidBrush(Color.FromArgb(180, Color.DodgerBlue)))
            {
                float side = (float)ancho * 10f;
                float x = 700f;
                float y = 150f;

                g.FillRectangle(fill, x, y, side, side);
                g.DrawRectangle(pen, x, y, side, side);
            }
        }
    }
}
