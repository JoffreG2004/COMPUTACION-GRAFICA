using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace shapes_2d
{
    public partial class FrmTrianguloRectangulo : Form
    {
        public FrmTrianguloRectangulo()
        {
            InitializeComponent();
        }

        double lado1, lado2, lado3;

        private void VerificaYMuestraRecomendacion()
        {
            bool tieneAncho = double.TryParse(txtLadoA.Text, out double a) && a > 0;
            bool tieneLargo = double.TryParse(txtLadoB.Text, out double b) && b > 0;
            bool tieneAltura = double.TryParse(txtLadoC.Text, out double c) && c > 0;

            int valoresIngresados = (tieneAncho ? 1 : 0) + (tieneLargo ? 1 : 0) + (tieneAltura ? 1 : 0);

            if (valoresIngresados == 2)
            {
                string recomendacion = "";

                if (tieneAncho && tieneLargo && !tieneAltura)
                {
                    double minAltura = Math.Abs(a - b);
                    double maxAltura = a + b;
                    recomendacion = $"Hipotenusa (c) debe estar entre {minAltura:F2} y {maxAltura:F2}";
                }
                else if (tieneAncho && tieneAltura && !tieneLargo)
                {
                    double minLargo = Math.Abs(a - c);
                    double maxLargo = a + c;
                    recomendacion = $"Cateto (b) debe estar entre {minLargo:F2} y {maxLargo:F2}";
                }
                else if (tieneLargo && tieneAltura && !tieneAncho)
                {
                    double minAncho = Math.Abs(b - c);
                    double maxAncho = b + c;
                    recomendacion = $"Cateto (a) debe estar entre {minAncho:F2} y {maxAncho:F2}";
                }

                LblRecomendacion.Text = recomendacion;
            }
            else
            {
                LblRecomendacion.Text = "";
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            VerificaYMuestraRecomendacion();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLadoA.Text, out lado1) || lado1 <= 0)
            {
                MessageBox.Show("Cateto (a) debe ser un número válido mayor a 0");
                return;
            }

            if (!double.TryParse(txtLadoB.Text, out lado2) || lado2 <= 0)
            {
                MessageBox.Show("Cateto (b) debe ser un número válido mayor a 0");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLadoC.Text))
            {
                // Calcular hipotenusa por Pitágoras
                lado3 = Math.Sqrt(lado1 * lado1 + lado2 * lado2);
                txtLadoC.Text = lado3.ToString("F2");
            }
            else
            {
                if (!double.TryParse(txtLadoC.Text, out lado3) || lado3 <= 0)
                {
                    MessageBox.Show("Hipotenusa (c) debe ser un número válido mayor a 0");
                    return;
                }
            }

            // Validar que sea un triángulo rectángulo (a² + b² = c²)
            double sumaCuadrados = lado1 * lado1 + lado2 * lado2;
            double hipotenusaCuadrada = lado3 * lado3;
            double tolerancia = 0.01;

            if (Math.Abs(sumaCuadrados - hipotenusaCuadrada) > tolerancia)
            {
                MessageBox.Show($"Los valores no forman un triángulo rectángulo válido.\nVerifica: a² + b² debe ser aproximadamente igual a c²");
                return;
            }

            pnlTriangulo.Invalidate();

            double perimetro = lado1 + lado2 + lado3;
            double area = (lado1 * lado2) / 2.0;

            LblPerimetro.Text = $"Perímetro: {perimetro:F2}";
            LblArea.Text = $"Área: {area:F2}";
        }

        private void BtnResetear_Click(object sender, EventArgs e)
        {
            txtLadoA.Text = "";
            txtLadoB.Text = "";
            txtLadoC.Text = "";

            LblPerimetro.Text = "Perimetro:";
            LblArea.Text = "Área:";

            lado1 = 0;
            lado2 = 0;
            lado3 = 0;

            pnlTriangulo.Invalidate();
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTriangulo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Clear panel background
            g.Clear(pnlTriangulo.BackColor);

            if (lado1 > 0 && lado2 > 0 && lado3 > 0)
            {
                // Use panel client rectangle as drawing bounds
                Rectangle panelBounds = pnlTriangulo.ClientRectangle;
                RectangleF bounds = new RectangleF(panelBounds.X, panelBounds.Y, panelBounds.Width, panelBounds.Height);
                const float padding = 16f;

                // Para triángulo rectángulo, los catetos son perpendiculares
                PointF[] points =
                {
                    new PointF(0f, (float)lado2),
                    new PointF((float)lado1, (float)lado2),
                    new PointF((float)lado1, 0f)
                };

                float minX = points.Min(p => p.X);
                float minY = points.Min(p => p.Y);
                float maxX = points.Max(p => p.X);
                float maxY = points.Max(p => p.Y);

                float width = maxX - minX;
                float height = maxY - minY;

                if (width <= 0f || height <= 0f)
                {
                    return;
                }

                float scale = Math.Min((bounds.Width - padding * 2f) / width, (bounds.Height - padding * 2f) / height);
                scale = Math.Max(0.1f, Math.Min(1f, scale)); // cap scale at 1f so it doesn't upscale beyond actual size

                float offsetX = bounds.X + (bounds.Width - width * scale) / 2f;
                float offsetY = bounds.Y + (bounds.Height - height * scale) / 2f;

                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new PointF(
                        offsetX + (points[i].X - minX) * scale,
                        offsetY + (points[i].Y - minY) * scale);
                }

                using (Pen pen = new Pen(Color.Green, 2))
                {
                    g.DrawPolygon(pen, points);
                }

                // Marcar el ángulo recto
                float cornerSize = 8f;
                g.DrawRectangle(new Pen(Color.Green, 1), points[1].X - cornerSize, points[2].Y, cornerSize, cornerSize);

                // Optional: draw bounds reference
                using (Pen boundsPen = new Pen(Color.FromArgb(80, Color.Gray), 1))
                {
                    boundsPen.DashStyle = DashStyle.Dash;
                    g.DrawRectangle(boundsPen, 0, 0, bounds.Width - 1, bounds.Height - 1);
                }
            }
        }
    }
}
