using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmParalelogramo : Form
    {
        private double ancho;
        private double altura;
        private double inclinacion;

        public FrmParalelogramo()
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

            if (!double.TryParse(TxtLargo.Text, out altura) || altura <= 0)
            {
                MessageBox.Show("Altura (b) debe ser un número válido mayor a 0");
                return;
            }

            if (!double.TryParse(TxtInclinacion.Text, out inclinacion) || inclinacion <= 0)
            {
                MessageBox.Show("Inclinación debe ser un número válido mayor a 0");
                return;
            }

            double lado = Math.Sqrt(altura * altura + inclinacion * inclinacion);
            double perimetro = 2 * (ancho + lado);
            double area = ancho * altura;

            LblPerimetro.Text = $"Perímetro: {perimetro:F2}";
            LblArea.Text = $"Área: {area:F2}";

            this.Invalidate();
        }

        private void BtnResetear_Click(object sender, EventArgs e)
        {
            TxtAncho.Text = "";
            TxtLargo.Text = "";
            TxtInclinacion.Text = "";
            LblPerimetro.Text = "Perimetro:";
            LblArea.Text = "Área:";
            ancho = 0;
            altura = 0;
            inclinacion = 0;
            this.Invalidate();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmParalelogramo_Paint(object sender, PaintEventArgs e)
        {
            if (ancho <= 0 || altura <= 0 || inclinacion <= 0)
            {
                return;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Black, 2))
            using (Brush fill = new SolidBrush(Color.FromArgb(180, Color.Goldenrod)))
            {
                float baseWidth = (float)ancho * 10f;
                float height = (float)altura * 10f;
                float offset = (float)inclinacion * 10f;

                float x = 700f;
                float y = 150f;

                PointF[] points =
                {
                    new PointF(x + offset, y),
                    new PointF(x + offset + baseWidth, y),
                    new PointF(x + baseWidth, y + height),
                    new PointF(x, y + height)
                };

                g.FillPolygon(fill, points);
                g.DrawPolygon(pen, points);
            }
        }
    }
}
