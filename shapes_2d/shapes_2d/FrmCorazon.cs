using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmCorazon : Form
    {
        private double tamaño;

        public FrmCorazon()
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

            double r = tamaño * 10d;
            double area = (Math.PI * r * r) + (1.4d * r * r);
            double perimetro = (2 * Math.PI * r) + (2 * Math.Sqrt(r * r + (1.4d * r) * (1.4d * r)));

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

        private void FrmCorazon_Paint(object sender, PaintEventArgs e)
        {
            if (tamaño <= 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Black, 2))
            using (Brush fill = new SolidBrush(Color.FromArgb(200, Color.Red)))
            {
                float scale = (float)tamaño;

                float offsetX = 700f;
                float offsetY = 150f;

                PointF[] points = new PointF[360];

                for (int i = 0; i < 360; i++)
                {
                    double t = i * Math.PI / 180d;

                    double x = 16 * Math.Pow(Math.Sin(t), 3);
                    double y = 13 * Math.Cos(t)
                             - 5 * Math.Cos(2 * t)
                             - 2 * Math.Cos(3 * t)
                             - Math.Cos(4 * t);

                    float drawX = offsetX + (float)((x + 16) * scale);
                    float drawY = offsetY + (float)((17 - y) * scale);

                    points[i] = new PointF(drawX, drawY);
                }

                g.FillPolygon(fill, points);
                g.DrawPolygon(pen, points);
            }
        }
    }
}
