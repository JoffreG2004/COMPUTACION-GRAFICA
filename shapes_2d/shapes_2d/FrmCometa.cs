using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmCometa : Form
    {
        private double ancho;
        private double largo;

        public FrmCometa()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAncho.Text, out ancho) || ancho <= 0)
            {
                MessageBox.Show("Ancho (A) debe ser un número válido mayor a 0");
                return;
            }

            if (!double.TryParse(txtLargo.Text, out largo) || largo <= 0)
            {
                MessageBox.Show("Largo (B) debe ser un número válido mayor a 0");
                return;
            }

            double halfWidth = ancho / 2d;
            double halfHeight = largo / 2d;
            double side = Math.Sqrt(halfWidth * halfWidth + halfHeight * halfHeight);
            double perimetro = 4 * side;
            double area = (ancho * largo) / 2d;

            lblPerimetro.Text = $"Perímetro: {perimetro:F2}";
            lblArea.Text = $"Área: {area:F2}";

            this.Invalidate();
        }

        private void BtnResetear_Click(object sender, EventArgs e)
        {
            txtAncho.Text = "";
            txtLargo.Text = "";
            lblPerimetro.Text = "Perimetro:";
            lblArea.Text = "Área:";
            ancho = 0;
            largo = 0;
            this.Invalidate();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCometa_Paint(object sender, PaintEventArgs e)
        {
            if (ancho <= 0 || largo <= 0)
            {
                return;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Black, 2))
            using (Brush fill = new SolidBrush(Color.FromArgb(180, Color.MediumPurple)))
            {
                float width = (float)ancho * 10f;
                float height = (float)largo * 10f;
                float x = 700f;
                float y = 150f;

                PointF[] points =
                {
                    new PointF(x + width / 2f, y),
                    new PointF(x + width, y + height / 2f),
                    new PointF(x + width / 2f, y + height),
                    new PointF(x, y + height / 2f)
                };

                g.FillPolygon(fill, points);
                g.DrawPolygon(pen, points);
            }
        }
    }
}
